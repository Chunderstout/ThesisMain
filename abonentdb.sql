-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 17, 2024 at 02:59 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `abonentdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `abonent`
--

CREATE TABLE `abonent` (
  `account_id` int(11) DEFAULT NULL,
  `abnt_firstname` varchar(25) NOT NULL,
  `abnt_middlename` varchar(25) NOT NULL,
  `abnt_lastname` varchar(25) NOT NULL,
  `abnt_datebirth` date NOT NULL,
  `abnt_gender` varchar(10) NOT NULL,
  `abnt_adress` text NOT NULL,
  `adnt_passeries` varchar(4) NOT NULL,
  `abnt_passnumber` varchar(6) NOT NULL,
  `abnt_passissue` text NOT NULL,
  `abnt_phonenumber` varchar(15) NOT NULL,
  `abnt_email` varchar(50) NOT NULL,
  `abnt_numresidents` int(11) NOT NULL,
  `abnt_propertysqr` int(11) NOT NULL,
  `abnt_gasconsumption` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `abonent`
--

INSERT INTO `abonent` (`account_id`, `abnt_firstname`, `abnt_middlename`, `abnt_lastname`, `abnt_datebirth`, `abnt_gender`, `abnt_adress`, `adnt_passeries`, `abnt_passnumber`, `abnt_passissue`, `abnt_phonenumber`, `abnt_email`, `abnt_numresidents`, `abnt_propertysqr`, `abnt_gasconsumption`) VALUES
(2, 'Кирилл', 'Васильев', 'Денисович', '1994-07-20', 'Муж', 'Красноармейская 162', '6009', '223484', 'ГУ МВД по ростовской области', '89094531129', 'devalbert@gmail.com', 3, 54, 28),
(4, 'Иван', 'Алферов', 'Александрович', '2000-06-01', 'Муж', '25 линия 25', '6020', '821223', 'ГУ МВД по Ростовской области', '89612686378', 'alferivan@gmail.com', 1, 21, 19);

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `account_id` int(11) NOT NULL,
  `account_number` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`account_id`, `account_number`) VALUES
(2, '1930373213'),
(3, '970948104'),
(4, '1132832695');

-- --------------------------------------------------------

--
-- Table structure for table `consumption_rates`
--

CREATE TABLE `consumption_rates` (
  `rate_id` int(11) NOT NULL,
  `rate_value` decimal(10,1) NOT NULL,
  `rate_name` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `consumption_rates`
--

INSERT INTO `consumption_rates` (`rate_id`, `rate_value`, `rate_name`) VALUES
(1, 12.4, 'ОТ'),
(2, 29.2, 'ПиК'),
(3, 21.0, 'ПЛ');

-- --------------------------------------------------------

--
-- Table structure for table `documentact`
--

CREATE TABLE `documentact` (
  `act_id` int(11) NOT NULL,
  `account_id` int(11) DEFAULT NULL,
  `act_eqmodel` varchar(50) NOT NULL,
  `act_price` int(11) NOT NULL,
  `act_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `documentact`
--

INSERT INTO `documentact` (`act_id`, `account_id`, `act_eqmodel`, `act_price`, `act_date`) VALUES
(4, 2, 'Газовый счетчик BK G4;-6', 1242, '2024-05-01'),
(5, 2, 'Газовые счетчик ВК G4T', 4122, '2024-05-01'),
(8, 4, 'газовая плита gorenie', 4123, '2024-02-23');

-- --------------------------------------------------------

--
-- Table structure for table `documentcontract`
--

CREATE TABLE `documentcontract` (
  `contract_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `contract_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `documentcontract`
--

INSERT INTO `documentcontract` (`contract_id`, `account_id`, `contract_date`) VALUES
(1, 2, '2004-06-17'),
(2, 3, '2018-06-07'),
(3, 4, '2024-03-13');

-- --------------------------------------------------------

--
-- Table structure for table `documentrequest`
--

CREATE TABLE `documentrequest` (
  `request_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `request_eqmodel` varchar(50) NOT NULL,
  `request_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `documentrequest`
--

INSERT INTO `documentrequest` (`request_id`, `account_id`, `request_eqmodel`, `request_date`) VALUES
(1, 2, 'счетчик C3P0-13', '2024-02-02'),
(2, 4, 'счетчик KLM-13', '2023-12-22');

-- --------------------------------------------------------

--
-- Table structure for table `equipmentcounter`
--

CREATE TABLE `equipmentcounter` (
  `counter_id` int(11) NOT NULL,
  `counter_model` varchar(50) NOT NULL,
  `account_id` int(11) NOT NULL,
  `counter_dateval` date NOT NULL,
  `counter_datenextcheck` date NOT NULL,
  `counter_location` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipmentcounter`
--

INSERT INTO `equipmentcounter` (`counter_id`, `counter_model`, `account_id`, `counter_dateval`, `counter_datenextcheck`, `counter_location`) VALUES
(1, 'счетчик газовый BD-4', 2, '2015-12-25', '2024-12-25', 'под лестницей'),
(2, 'счетчик газовый BD-4.5', 4, '2023-12-15', '2024-12-15', 'В лючке за раковиной');

-- --------------------------------------------------------

--
-- Table structure for table `equipmentother`
--

CREATE TABLE `equipmentother` (
  `eqother_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `eqother_model` varchar(50) NOT NULL,
  `eqother_type` varchar(20) NOT NULL,
  `eqother_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipmentother`
--

INSERT INTO `equipmentother` (`eqother_id`, `account_id`, `eqother_model`, `eqother_type`, `eqother_date`) VALUES
(1, 2, 'Плита Gorenie', 'Плита', '2020-02-06');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `tr_id` int(11) NOT NULL,
  `account_id` int(11) DEFAULT NULL,
  `rate_id` int(11) DEFAULT NULL,
  `tr_totalsum` decimal(10,2) NOT NULL,
  `tr_payment` decimal(10,2) NOT NULL,
  `tr_closed` tinyint(1) NOT NULL,
  `tr_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`tr_id`, `account_id`, `rate_id`, `tr_totalsum`, `tr_payment`, `tr_closed`, `tr_date`) VALUES
(2, 2, 1, 272.68, 550.00, 1, '2024-05-13'),
(3, 2, 1, 272.68, 240.00, 0, '2024-04-13'),
(4, 2, 3, 461.79, 550.00, 1, '2024-05-13'),
(5, 4, 3, 461.79, 550.00, 1, '2024-05-13');

--
-- Triggers `transactions`
--
DELIMITER $$
CREATE TRIGGER `calculate_tr_totalsum` BEFORE INSERT ON `transactions` FOR EACH ROW BEGIN
  DECLARE rate_value DECIMAL(10,1);
  DECLARE numresidents INT;

SELECT consumption_rates.rate_value, abonent.abnt_numresidents
INTO rate_value, numresidents
FROM consumption_rates
JOIN account ON consumption_rates.rate_id = NEW.rate_id
JOIN abonent ON account.account_id = abonent.account_id
LIMIT 1;

  SET NEW.tr_totalsum = rate_value * 7.33 * numresidents;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `update_tr_closed` BEFORE INSERT ON `transactions` FOR EACH ROW BEGIN
  SET @total_sum = (SELECT rate_value * 7.33 * abnt_numresidents
                     FROM consumption_rates cr
                     JOIN abonent a ON a.account_id = NEW.account_id
                     WHERE cr.rate_id = NEW.rate_id);
  IF NEW.tr_payment >= @total_sum THEN
    SET NEW.tr_closed = 1;
  ELSE
    SET NEW.tr_closed = 0;
  END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userid` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userid`, `username`, `password`, `role`) VALUES
(1, 'Admin', 'Admin', 'Admin'),
(2, 'Vasilyev', '8192833', 'user'),
(3, 'Antonov', 'Kd38Jczx', 'user'),
(4, 'user', 'user', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `abonent`
--
ALTER TABLE `abonent`
  ADD KEY `fk_abonent_account` (`account_id`);

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`account_id`);

--
-- Indexes for table `consumption_rates`
--
ALTER TABLE `consumption_rates`
  ADD PRIMARY KEY (`rate_id`);

--
-- Indexes for table `documentact`
--
ALTER TABLE `documentact`
  ADD PRIMARY KEY (`act_id`),
  ADD KEY `fk_documentact_account` (`account_id`);

--
-- Indexes for table `documentcontract`
--
ALTER TABLE `documentcontract`
  ADD PRIMARY KEY (`contract_id`),
  ADD UNIQUE KEY `account_id` (`account_id`);

--
-- Indexes for table `documentrequest`
--
ALTER TABLE `documentrequest`
  ADD PRIMARY KEY (`request_id`),
  ADD UNIQUE KEY `account_id` (`account_id`);

--
-- Indexes for table `equipmentcounter`
--
ALTER TABLE `equipmentcounter`
  ADD PRIMARY KEY (`counter_id`),
  ADD UNIQUE KEY `account_id` (`account_id`);

--
-- Indexes for table `equipmentother`
--
ALTER TABLE `equipmentother`
  ADD PRIMARY KEY (`eqother_id`),
  ADD UNIQUE KEY `account_id` (`account_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`tr_id`),
  ADD KEY `fk_transactions_account` (`account_id`),
  ADD KEY `fk_transactions_consumption_rates` (`rate_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `account_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `consumption_rates`
--
ALTER TABLE `consumption_rates`
  MODIFY `rate_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `documentact`
--
ALTER TABLE `documentact`
  MODIFY `act_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `documentcontract`
--
ALTER TABLE `documentcontract`
  MODIFY `contract_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `documentrequest`
--
ALTER TABLE `documentrequest`
  MODIFY `request_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `equipmentcounter`
--
ALTER TABLE `equipmentcounter`
  MODIFY `counter_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `equipmentother`
--
ALTER TABLE `equipmentother`
  MODIFY `eqother_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `tr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `abonent`
--
ALTER TABLE `abonent`
  ADD CONSTRAINT `fk_abonent_account` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`);

--
-- Constraints for table `documentact`
--
ALTER TABLE `documentact`
  ADD CONSTRAINT `fk_documentact_account` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`);

--
-- Constraints for table `documentcontract`
--
ALTER TABLE `documentcontract`
  ADD CONSTRAINT `documentcontract_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`);

--
-- Constraints for table `documentrequest`
--
ALTER TABLE `documentrequest`
  ADD CONSTRAINT `documentrequest_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`);

--
-- Constraints for table `equipmentcounter`
--
ALTER TABLE `equipmentcounter`
  ADD CONSTRAINT `equipmentcounter_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`);

--
-- Constraints for table `equipmentother`
--
ALTER TABLE `equipmentother`
  ADD CONSTRAINT `equipmentother_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`);

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `fk_transactions_account` FOREIGN KEY (`account_id`) REFERENCES `account` (`account_id`),
  ADD CONSTRAINT `fk_transactions_consumption_rates` FOREIGN KEY (`rate_id`) REFERENCES `consumption_rates` (`rate_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
