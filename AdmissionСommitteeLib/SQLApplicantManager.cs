using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdmissionСommitteeLib
{
    public class SQLApplicantManager : IApplicantManager
    {
        private MySqlConnection conn;

        public List<ApplicantRanking> GetApplicantRankings()
        {
            List<ApplicantRanking> result = new List<ApplicantRanking>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();

                const string query = @"
                    SELECT 
                        a.full_name AS FullName,
                        p.program_name AS ProgramName,
                        r.total_score AS TotalScore,
                        r.position AS Position,
                        r.list_type AS ListType
                    FROM ranking_lists r
                    JOIN applicants a ON r.applicant_id = a.id
                    JOIN study_programs p ON r.program_id = p.id
                    ORDER BY p.program_name, r.list_type, r.position";

                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ApplicantRanking ranking = new ApplicantRanking
                        {
                            FullName = reader.GetString("FullName"),
                            ProgramName = reader.GetString("ProgramName"),
                            TotalScore = reader.GetDecimal("TotalScore"),
                            Position = reader.GetInt32("Position"),
                            ListType = reader.GetString("ListType")
                        };

                        result.Add(ranking);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке рейтингов абитуриентов: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return result;
        }

        public List<Applicant> GetApplicants()
        {
            List<Applicant> result = new List<Applicant>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();

                const string query = @"
                    SELECT 
                        id,
                        full_name,
                        birth_date,
                        passport_series,
                        passport_number,
                        phone,
                        email,
                        snils,
                        address
                    FROM applicants";

                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Applicant applicant = new Applicant
                        {
                            Id = reader.GetInt32("id"),
                            FullName = reader.GetString("full_name"),
                            BirthDate = reader.GetDateTime("birth_date"),
                            PassportSeries = reader.GetString("passport_series"),
                            PassportNumber = reader.GetString("passport_number"),
                            Phone = reader.GetString("phone"),
                            Email = reader.GetString("email"),
                            SNILS = reader.GetString("snils"),
                            Address = reader.GetString("address")
                        };

                        result.Add(applicant);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке абитуриентов: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return result;
        }

        public string AddApplicant(Applicant applicant)
        {
            using (MySqlConnection conn = new MySqlConnection(AppSettings.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Проверяем, нет ли уже абитуриента с таким паспортом
                    string checkQuery = "SELECT COUNT(*) FROM applicants WHERE passport_series = @PassportSeries AND passport_number = @PassportNumber";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@PassportSeries", applicant.PassportSeries);
                        checkCommand.Parameters.AddWithValue("@PassportNumber", applicant.PassportNumber);

                        long existingCount = (long)checkCommand.ExecuteScalar();
                        if (existingCount > 0)
                        {
                            return "Ошибка: абитуриент с таким паспортом уже существует";
                        }
                    }

                    string insertQuery = @"
                        INSERT INTO applicants 
                        (full_name, birth_date, passport_series, passport_number, phone, email, snils, address) 
                        VALUES (@FullName, @BirthDate, @PassportSeries, @PassportNumber, @Phone, @Email, @SNILS, @Address)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@FullName", applicant.FullName);
                        command.Parameters.AddWithValue("@BirthDate", applicant.BirthDate);
                        command.Parameters.AddWithValue("@PassportSeries", applicant.PassportSeries);
                        command.Parameters.AddWithValue("@PassportNumber", applicant.PassportNumber);
                        command.Parameters.AddWithValue("@Phone", applicant.Phone);
                        command.Parameters.AddWithValue("@Email", applicant.Email);
                        command.Parameters.AddWithValue("@SNILS", applicant.SNILS);
                        command.Parameters.AddWithValue("@Address", applicant.Address);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Новый абитуриент успешно добавлен";
                        }
                        else
                        {
                            return "Ошибка: абитуриент не был добавлен";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Ошибка при добавлении абитуриента: " + ex.Message;
                }
            }
        }

        public string DeleteApplicant(int applicantId)
        {
            using (MySqlConnection conn = new MySqlConnection(AppSettings.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Сначала удаляем связанные записи
                    string deleteRankings = "DELETE FROM ranking_lists WHERE applicant_id = @ApplicantId";
                    using (MySqlCommand cmd1 = new MySqlCommand(deleteRankings, conn))
                    {
                        cmd1.Parameters.AddWithValue("@ApplicantId", applicantId);
                        cmd1.ExecuteNonQuery();
                    }

                    string deleteApplications = "DELETE FROM applications WHERE applicant_id = @ApplicantId";
                    using (MySqlCommand cmd2 = new MySqlCommand(deleteApplications, conn))
                    {
                        cmd2.Parameters.AddWithValue("@ApplicantId", applicantId);
                        cmd2.ExecuteNonQuery();
                    }

                    string deleteDocuments = "DELETE FROM educational_documents WHERE applicant_id = @ApplicantId";
                    using (MySqlCommand cmd3 = new MySqlCommand(deleteDocuments, conn))
                    {
                        cmd3.Parameters.AddWithValue("@ApplicantId", applicantId);
                        cmd3.ExecuteNonQuery();
                    }

                    // Затем удаляем абитуриента
                    string deleteApplicant = "DELETE FROM applicants WHERE id = @ApplicantId";
                    using (MySqlCommand cmd4 = new MySqlCommand(deleteApplicant, conn))
                    {
                        cmd4.Parameters.AddWithValue("@ApplicantId", applicantId);

                        int rowsAffected = cmd4.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Абитуриент успешно удален";
                        }
                        else
                        {
                            return "Ошибка: абитуриент не был удален";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Ошибка при удалении абитуриента: " + ex.Message;
                }
            }
        }

        public List<StudyProgram> GetStudyPrograms()
        {
            List<StudyProgram> result = new List<StudyProgram>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();

                const string query = @"
                    SELECT 
                        id,
                        program_code,
                        program_name,
                        budget_places,
                        contract_places,
                        tuition_fee
                    FROM study_programs
                    ORDER BY program_name";

                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudyProgram program = new StudyProgram
                        {
                            Id = reader.GetInt32("id"),
                            ProgramCode = reader.GetString("program_code"),
                            ProgramName = reader.GetString("program_name"),
                            BudgetPlaces = reader.GetInt32("budget_places"),
                            ContractPlaces = reader.GetInt32("contract_places"),
                            TuitionFee = reader.GetDecimal("tuition_fee")
                        };

                        result.Add(program);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке образовательных программ: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return result;
        }


    }
}
