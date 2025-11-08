using System;
using AdmissionСommitteeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace TestAdmissionCommittee
{
    [TestClass]
    public class TStorageApplicant
    {
        [TestMethod]
        [DataRow(1, "Иванов Иван Иванович", "4510", "123456", "+79991234567", "ivanov@mail.ru", "123-456-789-00", "г. Москва, ул. Ленина, д. 1")]
        [DataRow(2, "Петров Петр Петрович", "4511", "123457", "+79991234568", "petrov@mail.ru", "123-456-789-01", "г. Москва, ул. Пушкина, д. 2")]
        [DataRow(3, "Сидорова Анна Владимировна", "4512", "123458", "+79991234569", "sidorova@mail.ru", "123-456-789-02", "г. Москва, ул. Гагарина, д. 3")]
        public void AddApplicant_WhenApplicantDoesNotExist_ShouldAddSuccessfully(
        int id, string fullName, string passportSeries, string passportNumber,
        string phone, string email, string snils, string address)
        {
            // Arrange
            var mockDbManager = new Mock<IApplicantDBManager>();
            var storageApplicant = new StorageApplicant(mockDbManager.Object);

            var testApplicant = new Applicant
            {
                Id = id,
                FullName = fullName,
                BirthDate = new DateTime(2000, 05, 15),
                PassportSeries = passportSeries,
                PassportNumber = passportNumber,
                Phone = phone,
                Email = email,
                SNILS = snils,
                Address = address
            };


            // Настройка мока - абитуриент не существует
            mockDbManager.Setup(x => x.CheckApplicantExists(id)).Returns(false);
            // Настройка мока - успешное добавление в БД
            mockDbManager.Setup(x => x.InsertApplicant(It.IsAny<Applicant>())).Returns(true);

            // Act
            var result = storageApplicant.AddApplicant(testApplicant);

            // Assert
            Assert.IsTrue(result);
            mockDbManager.Verify(x => x.CheckApplicantExists(id), Times.Once);
            mockDbManager.Verify(x => x.InsertApplicant(It.Is<Applicant>(a =>
                a.Id == id &&
                a.FullName == fullName &&
                a.PassportSeries == passportSeries &&
                a.PassportNumber == passportNumber &&
                a.Phone == phone &&
                a.Email == email &&
                a.SNILS == snils &&
                a.Address == address
            )), Times.Once);
        }

        [TestMethod]
        [DataRow(1, "Иванов Иван Иванович", "4510", "123456")]
        [DataRow(2, "Петров Петр Петрович", "4511", "123457")]
        [DataRow(3, "Сидорова Анна Владимировна", "4512", "123458")]
        public void AddApplicant_WhenApplicantAlreadyExists_ShouldReturnFalse(
            int id, string fullName, string passportSeries, string passportNumber)
        {
            // Arrange
            var mockDbManager = new Mock<IApplicantDBManager>();
            var storageApplicant = new StorageApplicant(mockDbManager.Object);

            var testApplicant = new Applicant
            {
                Id = id,
                FullName = fullName,
                BirthDate = new DateTime(2000, 05, 15),
                PassportSeries = passportSeries,
                PassportNumber = passportNumber,
                Phone = "+79991234567",
                Email = "test@mail.ru",
                SNILS = "123-456-789-00",
                Address = "г. Москва, ул. Тестовая, д. 1"
            };

            // Настройка мока - абитуриент уже существует
            mockDbManager.Setup(x => x.CheckApplicantExists(id)).Returns(true);

            // Act
            var result = storageApplicant.AddApplicant(testApplicant);

            // Assert
            Assert.IsFalse(result);
            mockDbManager.Verify(x => x.CheckApplicantExists(id), Times.Once);
            mockDbManager.Verify(x => x.InsertApplicant(It.IsAny<Applicant>()), Times.Never);
        }

        
        [TestMethod]
        [DataRow(0, "Нулевой ID")] // Граничное значение
        [DataRow(-1, "Отрицательный ID")] // Некорректное значение
        [DataRow(int.MaxValue, "Максимальный ID")] // Граничное значение
        public void AddApplicant_WithBoundaryValues_ShouldWorkCorrectly(int id, string description)
        {
            // Arrange
            var mockDbManager = new Mock<IApplicantDBManager>();
            var storageApplicant = new StorageApplicant(mockDbManager.Object);

            var testApplicant = new Applicant
            {
                Id = id,
                FullName = "Тестовый Абитуриент",
                BirthDate = new DateTime(2000, 05, 15),
                PassportSeries = "4510",
                PassportNumber = "123456",
                Phone = "+79991234567",
                Email = "test@mail.ru",
                SNILS = "123-456-789-00",
                Address = "г. Москва, ул. Тестовая, д. 1"
            };

            mockDbManager.Setup(x => x.CheckApplicantExists(id)).Returns(false);
            mockDbManager.Setup(x => x.InsertApplicant(It.IsAny<Applicant>())).Returns(true);

            // Act
            var result = storageApplicant.AddApplicant(testApplicant);

            // Assert
            Assert.IsTrue(result, $"Тест не прошел для: {description}");
            mockDbManager.Verify(x => x.CheckApplicantExists(id), Times.Once);
            mockDbManager.Verify(x => x.InsertApplicant(It.Is<Applicant>(a => a.Id == id)), Times.Once);



        }

        // Новые тесты для удаления абитуриента

        [TestMethod]
        [DataRow(1, "Иванов Иван Иванович")]
        [DataRow(2, "Петров Петр Петрович")]
        [DataRow(3, "Сидорова Анна Владимировна")]
        public void DeleteApplicant_WhenUserConfirmsAndApplicantExists_ShouldDeleteSuccessfully(int applicantId, string fullName)
        {
            // Arrange
            var mockDbManager = new Mock<IApplicantDBManager>();
            var storageApplicant = new StorageApplicant(mockDbManager.Object);

            bool userConfirmation = true; // Пользователь нажал "ОК"

            mockDbManager.Setup(x => x.CheckApplicantExists(applicantId)).Returns(true);
            mockDbManager.Setup(x => x.DeleteApplicant(applicantId)).Returns(true);
            mockDbManager.Setup(x => x.GetDeleteResultMessage(applicantId, true)).Returns("Абитуриент успешно удалён");

            // Act
            var result = storageApplicant.DeleteApplicant(applicantId, userConfirmation);

            // Assert
            Assert.AreEqual("Абитуриент успешно удалён", result);
            mockDbManager.Verify(x => x.CheckApplicantExists(applicantId), Times.Once);
            mockDbManager.Verify(x => x.DeleteApplicant(applicantId), Times.Once);
            mockDbManager.Verify(x => x.GetDeleteResultMessage(applicantId, true), Times.Once);
        }
    }
}
