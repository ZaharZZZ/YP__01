-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Ноя 24 2025 г., 18:49
-- Версия сервера: 5.7.25
-- Версия PHP: 7.1.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `admission_commission`
--

-- --------------------------------------------------------

--
-- Структура таблицы `applicants`
--

CREATE TABLE `applicants` (
  `id` int(11) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `birth_date` date NOT NULL,
  `passport_series` varchar(10) NOT NULL,
  `passport_number` varchar(20) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `snils` varchar(14) DEFAULT NULL,
  `address` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `applicants`
--

INSERT INTO `applicants` (`id`, `full_name`, `birth_date`, `passport_series`, `passport_number`, `phone`, `email`, `snils`, `address`) VALUES
(1, 'Иванов Алексей Сергеевич', '2005-03-15', '4510', '123456', '+79161234567', 'ivanov.alex@mail.ru', '123-456-789-00', 'г. Москва, ул. Ленина, д. 25, кв. 12'),
(2, 'Петрова Мария Дмитриевна', '2005-07-22', '4511', '234567', '+79162345678', 'petrova.maria@gmail.com', '234-567-890-01', 'г. Москва, ул. Пушкина, д. 10, кв. 5'),
(3, 'Сидоров Андрей Викторович', '2004-12-05', '4512', '345678', '+79163456789', 'sidorov.andrey@yandex.ru', '345-678-901-02', 'г. Москва, пр. Мира, д. 15, кв. 8'),
(4, 'Козлова Елена Игоревна', '2005-05-18', '4513', '456789', '+79164567890', 'kozlova.elena@mail.ru', '456-789-012-03', 'г. Москва, ул. Гагарина, д. 7, кв. 3'),
(5, 'Никитин Денис Олегович', '2005-09-30', '4514', '567890', '+79165678901', 'nikitin.denis@gmail.com', '567-890-123-04', 'г. Москва, ул. Советская, д. 20, кв. 15'),
(6, 'Федорова Ольга Петровна', '2004-11-11', '4515', '678901', '+79166789012', 'fedorova.olga@yandex.ru', '678-901-234-05', 'г. Москва, ул. Кирова, д. 12, кв. 9'),
(7, 'Морозов Иван Александрович', '2005-02-28', '4516', '789012', '+79167890123', 'morozov.ivan@mail.ru', '789-012-345-06', 'г. Москва, ул. Лермонтова, д. 5, кв. 7'),
(8, 'Волкова Анастасия Сергеевна', '2005-06-14', '4517', '890123', '+79168901234', 'volkova.nastya@gmail.com', '890-123-456-07', 'г. Москва, ул. Чехова, д. 18, кв. 4'),
(9, 'Белов Павел Николаевич', '2004-10-08', '4518', '901234', '+79169012345', 'belov.pavel@yandex.ru', '901-234-567-08', 'г. Москва, ул. Горького, д. 9, кв. 11'),
(10, 'Смирнова Татьяна Владимировна', '2005-01-25', '4519', '012345', '+79160123456', 'smirnova.tanya@mail.ru', '012-345-678-09', 'г. Москва, ул. Маяковского, д. 3, кв. 6'),
(11, 'Кузнецов Михаил Андреевич', '2005-04-12', '4520', '123457', '+79161234568', 'kuznetsov.misha@mail.ru', '123-456-789-10', 'г. Москва, ул. Тверская, д. 14, кв. 8'),
(12, 'Андреева Юлия Викторовна', '2005-08-19', '4521', '234568', '+79162345679', 'andreeva.yulia@gmail.com', '234-567-890-11', 'г. Москва, ул. Садовая, д. 22, кв. 13'),
(13, 'Григорьев Артем Сергеевич', '2004-12-30', '4522', '345679', '+79163456780', 'grigoriev.artem@yandex.ru', '345-678-901-12', 'г. Москва, ул. Некрасова, д. 11, кв. 5'),
(14, 'Соколова Ирина Павловна', '2005-03-08', '4523', '456780', '+79164567891', 'sokolova.irina@mail.ru', '456-789-012-13', 'г. Москва, ул. Цветочная, д. 6, кв. 2'),
(15, 'Тихонов Роман Олегович', '2005-07-15', '4524', '567891', '+79165678902', 'tikhonov.roman@gmail.com', '567-890-123-14', 'г. Москва, ул. Лесная, д. 17, кв. 10'),
(16, 'Зайцева Екатерина Дмитриевна', '2004-11-22', '4525', '678902', '+79166789013', 'zaitseva.katya@yandex.ru', '678-901-234-15', 'г. Москва, ул. Речная, д. 8, кв. 7'),
(17, 'Комаров Алексей Владимирович', '2005-02-14', '4526', '789013', '+79167890124', 'komarov.alex@mail.ru', '789-012-345-16', 'г. Москва, ул. Солнечная, д. 13, кв. 9'),
(18, 'Орлова Марина Игоревна', '2005-06-27', '4527', '890124', '+79168901235', 'orlova.marina@gmail.com', '890-123-456-17', 'г. Москва, ул. Парковая, д. 4, кв. 3'),
(19, 'Лебедев Сергей Петрович', '2004-09-05', '4528', '901235', '+79169012346', 'lebedev.sergey@yandex.ru', '901-234-567-18', 'г. Москва, ул. Школьная, д. 19, кв. 14'),
(20, 'Новикова Анна Александровна', '2005-01-18', '4529', '012346', '+79160123457', 'novikova.anna@mail.ru', '012-345-678-19', 'г. Москва, ул. Молодежная, д. 2, кв. 1'),
(21, 'Фролов Дмитрий Евгеньевич', '2005-05-20', '4530', '123458', '+79161234569', 'frolov.dmitry@mail.ru', '123-456-789-20', 'г. Москва, ул. Центральная, д. 21, кв. 16'),
(22, 'Мельникова Светлана Анатольевна', '2005-09-10', '4531', '234569', '+79162345680', 'melnikova.svetlana@gmail.com', '234-567-890-21', 'г. Москва, ул. Заречная, д. 16, кв. 12'),
(23, 'Данилов Константин Ильич', '2004-12-15', '4532', '345680', '+79163456781', 'danilov.kostya@yandex.ru', '345-678-901-22', 'г. Москва, ул. Вишневая, д. 9, кв. 4'),
(24, 'Романова Вероника Сергеевна', '2005-04-03', '4533', '456781', '+79164567892', 'romanova.veronika@mail.ru', '456-789-012-23', 'г. Москва, ул. Яблочная, д. 14, кв. 8'),
(25, 'Жуков Артур Романович', '2005-08-25', '4534', '567892', '+79165678903', 'zhukov.artur@gmail.com', '567-890-123-24', 'г. Москва, ул. Кленовая, д. 7, кв. 5'),
(26, 'Сафонова Дарья Олеговна', '2004-11-05', '4535', '678903', '+79166789014', 'safonova.dasha@yandex.ru', '678-901-234-25', 'г. Москва, ул. Березовая, д. 12, кв. 9'),
(27, 'Егоров Владислав Андреевич', '2005-02-17', '4536', '789014', '+79167890125', 'egorov.vlad@mail.ru', '789-012-345-26', 'г. Москва, ул. Дубовая, д. 5, кв. 2'),
(28, 'Кудрявцева Любовь Викторовна', '2005-06-08', '4537', '890125', '+79168901236', 'kudryavtseva.luba@gmail.com', '890-123-456-27', 'г. Москва, ул. Сосновая, д. 18, кв. 11'),
(29, 'Блинов Антон Павлович', '2004-10-12', '4538', '901236', '+79169012347', 'blinov.anton@yandex.ru', '901-234-567-28', 'г. Москва, ул. Липовая, д. 3, кв. 7'),
(30, 'Горбунова Надежда Ивановна', '2005-01-30', '4539', '012347', '+79160123458', 'gorbunova.nadezhda@mail.ru', '012-345-678-29', 'г. Москва, ул. Рябиновая, д. 10, кв. 6'),
(31, 'Бабайка Олёша УрланУзбекович', '2007-11-24', '4356', '346542', '7546367', 'BaBai@gmai.coml', '45636356', '');

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `applicant_rankings_view`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `applicant_rankings_view` (
`position` int(11)
,`full_name` varchar(255)
,`program_name` varchar(255)
,`total_score` decimal(5,2)
,`list_type` varchar(20)
,`education_form` enum('очная','заочная','очно-заочная')
,`funding_source` enum('бюджет','договор')
,`original_provided` tinyint(1)
);

-- --------------------------------------------------------

--
-- Структура таблицы `applications`
--

CREATE TABLE `applications` (
  `id` int(11) NOT NULL,
  `applicant_id` int(11) NOT NULL,
  `program_id` int(11) NOT NULL,
  `application_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `status` enum('подано','принято','отклонено','на рассмотрении','зачислено') DEFAULT 'подано',
  `education_form` enum('очная','заочная','очно-заочная') NOT NULL,
  `funding_source` enum('бюджет','договор') NOT NULL,
  `original_provided` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `applications`
--

INSERT INTO `applications` (`id`, `applicant_id`, `program_id`, `application_date`, `status`, `education_form`, `funding_source`, `original_provided`) VALUES
(1, 1, 1, '2024-06-01 10:00:00', 'подано', 'заочная', 'договор', 0),
(2, 2, 1, '2024-06-01 10:15:00', 'на рассмотрении', 'очно-заочная', 'бюджет', 1),
(3, 3, 1, '2024-06-01 10:30:00', 'отклонено', 'очная', 'договор', 1),
(4, 4, 1, '2024-06-01 10:45:00', 'зачислено', 'заочная', 'бюджет', 0),
(5, 5, 1, '2024-06-01 11:00:00', 'принято', 'очно-заочная', 'договор', 1),
(6, 6, 1, '2024-06-01 11:15:00', 'подано', 'очная', 'бюджет', 1),
(7, 7, 1, '2024-06-01 11:30:00', 'на рассмотрении', 'заочная', 'договор', 0),
(8, 8, 1, '2024-06-01 11:45:00', 'отклонено', 'очно-заочная', 'бюджет', 1),
(9, 9, 1, '2024-06-01 12:00:00', 'зачислено', 'очная', 'договор', 1),
(10, 10, 1, '2024-06-01 12:15:00', 'принято', 'заочная', 'бюджет', 0),
(11, 11, 2, '2024-06-01 13:00:00', 'подано', 'очно-заочная', 'договор', 1),
(12, 12, 2, '2024-06-01 13:15:00', 'на рассмотрении', 'очная', 'бюджет', 1),
(13, 13, 2, '2024-06-01 13:30:00', 'отклонено', 'заочная', 'договор', 0),
(14, 14, 2, '2024-06-01 13:45:00', 'зачислено', 'очно-заочная', 'бюджет', 1),
(15, 15, 2, '2024-06-01 14:00:00', 'принято', 'очная', 'договор', 1),
(16, 16, 2, '2024-06-01 14:15:00', 'подано', 'заочная', 'бюджет', 0),
(17, 17, 2, '2024-06-01 14:30:00', 'на рассмотрении', 'очно-заочная', 'договор', 1),
(18, 18, 2, '2024-06-01 14:45:00', 'отклонено', 'очная', 'бюджет', 1),
(19, 19, 2, '2024-06-01 15:00:00', 'зачислено', 'заочная', 'договор', 0),
(20, 20, 2, '2024-06-01 15:15:00', 'принято', 'очно-заочная', 'бюджет', 1),
(21, 21, 3, '2024-06-01 16:00:00', 'подано', 'очная', 'договор', 1),
(22, 22, 3, '2024-06-01 16:15:00', 'на рассмотрении', 'заочная', 'бюджет', 0),
(23, 23, 3, '2024-06-01 16:30:00', 'отклонено', 'очно-заочная', 'договор', 1),
(24, 24, 3, '2024-06-01 16:45:00', 'зачислено', 'очная', 'бюджет', 1),
(25, 25, 3, '2024-06-01 17:00:00', 'принято', 'заочная', 'договор', 0),
(26, 26, 3, '2024-06-01 17:15:00', 'подано', 'очно-заочная', 'бюджет', 1),
(27, 27, 3, '2024-06-01 17:30:00', 'на рассмотрении', 'очная', 'договор', 1),
(28, 28, 3, '2024-06-01 17:45:00', 'отклонено', 'заочная', 'бюджет', 0),
(29, 29, 3, '2024-06-01 18:00:00', 'зачислено', 'очно-заочная', 'договор', 1),
(30, 30, 3, '2024-06-01 18:15:00', 'принято', 'очная', 'бюджет', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `educational_documents`
--

CREATE TABLE `educational_documents` (
  `id` int(11) NOT NULL,
  `applicant_id` int(11) NOT NULL,
  `document_type` enum('аттестат','диплом','справка') NOT NULL,
  `series` varchar(20) NOT NULL,
  `number` varchar(50) NOT NULL,
  `year_of_graduation` int(11) NOT NULL,
  `gpa` decimal(3,2) NOT NULL,
  `file_scan_path` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `educational_documents`
--

INSERT INTO `educational_documents` (`id`, `applicant_id`, `document_type`, `series`, `number`, `year_of_graduation`, `gpa`, `file_scan_path`) VALUES
(1, 1, 'аттестат', '123456', '1234567', 2023, '4.50', '/scans/1_attestat.pdf'),
(2, 2, 'аттестат', '234567', '2345678', 2023, '4.80', '/scans/2_attestat.pdf'),
(3, 3, 'аттестат', '345678', '3456789', 2023, '4.20', '/scans/3_attestat.pdf'),
(4, 4, 'аттестат', '456789', '4567890', 2023, '4.70', '/scans/4_attestat.pdf'),
(5, 5, 'аттестат', '567890', '5678901', 2023, '4.10', '/scans/5_attestat.pdf'),
(6, 6, 'аттестат', '678901', '6789012', 2023, '4.90', '/scans/6_attestat.pdf'),
(7, 7, 'аттестат', '789012', '7890123', 2023, '4.30', '/scans/7_attestat.pdf'),
(8, 8, 'аттестат', '890123', '8901234', 2023, '4.60', '/scans/8_attestat.pdf'),
(9, 9, 'аттестат', '901234', '9012345', 2023, '4.00', '/scans/9_attestat.pdf'),
(10, 10, 'аттестат', '012345', '0123456', 2023, '4.40', '/scans/10_attestat.pdf'),
(11, 11, 'аттестат', '112233', '1122334', 2023, '4.70', '/scans/11_attestat.pdf'),
(12, 12, 'аттестат', '223344', '2233445', 2023, '4.20', '/scans/12_attestat.pdf'),
(13, 13, 'аттестат', '334455', '3344556', 2023, '4.80', '/scans/13_attestat.pdf'),
(14, 14, 'аттестат', '445566', '4455667', 2023, '4.10', '/scans/14_attestat.pdf'),
(15, 15, 'аттестат', '556677', '5566778', 2023, '4.90', '/scans/15_attestat.pdf'),
(16, 16, 'аттестат', '667788', '6677889', 2023, '4.30', '/scans/16_attestat.pdf'),
(17, 17, 'аттестат', '778899', '7788990', 2023, '4.60', '/scans/17_attestat.pdf'),
(18, 18, 'аттестат', '889900', '8899001', 2023, '4.00', '/scans/18_attestat.pdf'),
(19, 19, 'аттестат', '990011', '9900112', 2023, '4.50', '/scans/19_attestat.pdf'),
(20, 20, 'аттестат', '100200', '1002003', 2023, '4.40', '/scans/20_attestat.pdf'),
(21, 21, 'аттестат', '200300', '2003004', 2023, '4.60', '/scans/21_attestat.pdf'),
(22, 22, 'аттестат', '300400', '3004005', 2023, '4.10', '/scans/22_attestat.pdf'),
(23, 23, 'аттестат', '400500', '4005006', 2023, '4.70', '/scans/23_attestat.pdf'),
(24, 24, 'аттестат', '500600', '5006007', 2023, '4.20', '/scans/24_attestat.pdf'),
(25, 25, 'аттестат', '600700', '6007008', 2023, '4.80', '/scans/25_attestat.pdf'),
(26, 26, 'аттестат', '700800', '7008009', 2023, '4.30', '/scans/26_attestat.pdf'),
(27, 27, 'аттестат', '800900', '8009001', 2023, '4.90', '/scans/27_attestat.pdf'),
(28, 28, 'аттестат', '900100', '9001002', 2023, '4.40', '/scans/28_attestat.pdf'),
(29, 29, 'аттестат', '100900', '1009003', 2023, '4.00', '/scans/29_attestat.pdf'),
(30, 30, 'аттестат', '200800', '2008004', 2023, '4.50', '/scans/30_attestat.pdf');

-- --------------------------------------------------------

--
-- Структура таблицы `ranking_lists`
--

CREATE TABLE `ranking_lists` (
  `id` int(11) NOT NULL,
  `applicant_id` int(11) NOT NULL,
  `program_id` int(11) NOT NULL,
  `total_score` decimal(5,2) NOT NULL,
  `list_type` varchar(20) NOT NULL,
  `position` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `ranking_lists`
--

INSERT INTO `ranking_lists` (`id`, `applicant_id`, `program_id`, `total_score`, `list_type`, `position`) VALUES
(1, 1, 1, '4.50', 'бюджет', 5),
(2, 2, 1, '4.80', 'бюджет', 2),
(3, 3, 1, '4.20', 'договор', 8),
(4, 4, 1, '4.70', 'бюджет', 3),
(5, 5, 1, '4.10', 'договор', 9),
(6, 6, 1, '4.90', 'бюджет', 1),
(7, 7, 1, '4.30', 'бюджет', 7),
(8, 8, 1, '4.60', 'договор', 4),
(9, 9, 1, '4.00', 'бюджет', 10),
(10, 10, 1, '4.40', 'бюджет', 6),
(11, 11, 2, '4.70', 'бюджет', 3),
(12, 12, 2, '4.20', 'бюджет', 8),
(13, 13, 2, '4.80', 'договор', 2),
(14, 14, 2, '4.10', 'бюджет', 9),
(15, 15, 2, '4.90', 'договор', 1),
(16, 16, 2, '4.30', 'бюджет', 7),
(17, 17, 2, '4.60', 'бюджет', 4),
(18, 18, 2, '4.00', 'договор', 10),
(19, 19, 2, '4.50', 'бюджет', 5),
(20, 20, 2, '4.40', 'бюджет', 6),
(21, 21, 3, '4.60', 'бюджет', 4),
(22, 22, 3, '4.10', 'бюджет', 9),
(23, 23, 3, '4.70', 'договор', 3),
(24, 24, 3, '4.20', 'бюджет', 8),
(25, 25, 3, '4.80', 'договор', 2),
(26, 26, 3, '4.30', 'бюджет', 7),
(27, 27, 3, '4.90', 'бюджет', 1),
(28, 28, 3, '4.40', 'договор', 6),
(29, 29, 3, '4.00', 'бюджет', 10),
(30, 30, 3, '4.50', 'бюджет', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `study_programs`
--

CREATE TABLE `study_programs` (
  `id` int(11) NOT NULL,
  `program_code` varchar(20) NOT NULL,
  `program_name` varchar(255) NOT NULL,
  `budget_places` int(11) NOT NULL,
  `contract_places` int(11) NOT NULL,
  `tuition_fee` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `study_programs`
--

INSERT INTO `study_programs` (`id`, `program_code`, `program_name`, `budget_places`, `contract_places`, `tuition_fee`) VALUES
(1, '09.02.07', 'Информационные системы и программирование', 25, 15, '45000.00'),
(2, '38.02.01', 'Экономика и бухгалтерский учет', 20, 10, '40000.00'),
(3, '40.02.01', 'Право и организация социального обеспечения', 30, 20, '38000.00');

-- --------------------------------------------------------

--
-- Структура для представления `applicant_rankings_view`
--
DROP TABLE IF EXISTS `applicant_rankings_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `applicant_rankings_view`  AS  select `r`.`position` AS `position`,`a`.`full_name` AS `full_name`,`p`.`program_name` AS `program_name`,`r`.`total_score` AS `total_score`,`r`.`list_type` AS `list_type`,`app`.`education_form` AS `education_form`,`app`.`funding_source` AS `funding_source`,`app`.`original_provided` AS `original_provided` from (((`ranking_lists` `r` join `applicants` `a` on((`r`.`applicant_id` = `a`.`id`))) join `study_programs` `p` on((`r`.`program_id` = `p`.`id`))) join `applications` `app` on(((`app`.`applicant_id` = `a`.`id`) and (`app`.`program_id` = `p`.`id`)))) order by `r`.`program_id`,`r`.`list_type`,`r`.`position` ;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `applicants`
--
ALTER TABLE `applicants`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_passport` (`passport_series`,`passport_number`),
  ADD UNIQUE KEY `unique_snils` (`snils`),
  ADD KEY `idx_applicants_name` (`full_name`);

--
-- Индексы таблицы `applications`
--
ALTER TABLE `applications`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_application` (`applicant_id`,`program_id`),
  ADD KEY `program_id` (`program_id`),
  ADD KEY `idx_applications_status` (`status`),
  ADD KEY `idx_applications_date` (`application_date`);

--
-- Индексы таблицы `educational_documents`
--
ALTER TABLE `educational_documents`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_document` (`series`,`number`),
  ADD KEY `applicant_id` (`applicant_id`);

--
-- Индексы таблицы `ranking_lists`
--
ALTER TABLE `ranking_lists`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_ranking` (`applicant_id`,`program_id`,`list_type`),
  ADD KEY `program_id` (`program_id`),
  ADD KEY `idx_ranking_score` (`total_score`),
  ADD KEY `idx_ranking_type` (`list_type`);

--
-- Индексы таблицы `study_programs`
--
ALTER TABLE `study_programs`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `applicants`
--
ALTER TABLE `applicants`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT для таблицы `applications`
--
ALTER TABLE `applications`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT для таблицы `educational_documents`
--
ALTER TABLE `educational_documents`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT для таблицы `ranking_lists`
--
ALTER TABLE `ranking_lists`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT для таблицы `study_programs`
--
ALTER TABLE `study_programs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `applications`
--
ALTER TABLE `applications`
  ADD CONSTRAINT `applications_ibfk_1` FOREIGN KEY (`applicant_id`) REFERENCES `applicants` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `applications_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `study_programs` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `educational_documents`
--
ALTER TABLE `educational_documents`
  ADD CONSTRAINT `educational_documents_ibfk_1` FOREIGN KEY (`applicant_id`) REFERENCES `applicants` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `ranking_lists`
--
ALTER TABLE `ranking_lists`
  ADD CONSTRAINT `ranking_lists_ibfk_1` FOREIGN KEY (`applicant_id`) REFERENCES `applicants` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `ranking_lists_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `study_programs` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
