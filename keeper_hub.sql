-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 05, 2024 at 04:04 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `keeper_hub`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `UserID` int(255) NOT NULL,
  `status` varchar(20) NOT NULL,
  `roleID` varchar(30) NOT NULL,
  `fullname` varchar(25) NOT NULL,
  `depart` varchar(60) NOT NULL,
  `password` varchar(16) NOT NULL,
  `user_type` varchar(15) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `date` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`UserID`, `status`, `roleID`, `fullname`, `depart`, `password`, `user_type`, `gender`, `date`) VALUES
(1, 'Admin', 'admin', 'ICT Administrator', 'CAS', 'admin', 'Admin', 'None', '2023-12-28'),
(3, 'Faculty', '21872 3781', 'Kim Ann', 'CAS', 'kim', 'User', '0', '2023-12-28'),
(4, 'Faculty', 'jn2873', 'Henry Tan', 'CIT', 'henry', 'User', '0', '2023-12-28'),
(5, 'Student', '298 82 9-', 'Zhar Ken', 'BSCS 3A', 'ken', 'User', '0', '2023-12-28'),
(7, 'Faculty', '392 039', 'Jennifer Chiu', 'CENG', 'd094a997ef61e6b0', 'User', 'Female', '2023-12-28'),
(8, 'Student', '38278 872', 'Cassy Lim', 'BPED 3A', 'cassy', 'User', 'Others', '2023-12-28'),
(14, 'Student', '283 7', 'Kyle K', 'JSAk', 'pass', 'User', 'Male', '2023-12-28'),
(15, 'Student', '1234', 'Kelzy Cap', 'BSIS 1A', 'kelzy', 'User', 'Male', '2023-12-28'),
(16, 'Student', 'user2', 'Glu', 'EDUC', 'glu', 'User', 'Female', '2023-12-29'),
(18, 'Faculty', 'user', 'Luis Man', 'CAS', 'luis', 'User', 'Male', '2023-12-30'),
(20, 'Student', '4431', 'Gojo Sensei', 'BSCS - 3A', 'gojo', 'User', 'Male', '2024-01-04'),
(21, 'Faculty', 'fsdfsd', 'fdsfsdf', 'fdsfsdf', 'fff', 'User', 'Female', '2024-01-04');

-- --------------------------------------------------------

--
-- Table structure for table `borrowed`
--

CREATE TABLE `borrowed` (
  `BorrowedID` int(11) NOT NULL,
  `UserID` int(255) NOT NULL,
  `ItemID` int(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `Remarks` varchar(255) NOT NULL,
  `dateTime` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrowed`
--

INSERT INTO `borrowed` (`BorrowedID`, `UserID`, `ItemID`, `Category`, `ItemName`, `Description`, `Quantity`, `Remarks`, `dateTime`) VALUES
(1, 18, 0, 'Monitors', 'Crion', 'Crion Monitors', 13, 'Functional', '2023-12-30 18:12:20'),
(2, 18, 2, 'System Unit', 'Dell', '4 x 4', 10, 'Functional', '2024-01-02 09:19:28'),
(3, 18, 6, 'Keyboard\r\n', 'HP', 'None', 7, 'Functional', '2024-01-02 09:35:15'),
(4, 18, 9, 'Mouse', 'Hex', 'hex mouse', 2, 'Functional', '2024-01-02 14:12:28'),
(5, 18, 11, 'Monitors', 'HP', 'None', 5, 'Functional', '2024-01-02 14:39:37'),
(6, 19, 10, 'Monitors', 'Crion', 'Crion Monitors', 3, 'Functional', '2024-01-02 17:52:58'),
(7, 0, 8, 'Mouse', 'Hex\r\n', 'clinder mouse', 2, 'Functional', '2024-01-02 18:09:08'),
(8, 16, 10, 'Monitors', 'Crion', 'Crion Monitors', 0, 'Functional', '2024-01-03 16:37:26'),
(9, 16, 10, 'Monitors', 'Crion', 'Crion Monitors', 5, 'Functional', '2024-01-03 16:51:18'),
(10, 15, 10, 'Monitors', 'Crion', 'Crion Monitors', 5, 'Functional', '2024-01-03 17:09:59'),
(11, 15, 2, 'System Unit', 'Dell', '4 x 4', 5, 'Functional', '2024-01-03 17:13:15'),
(12, 20, 1, 'Tools', 'Screw Driver', 'None\r\n', 5, 'Functional', '2024-01-04 21:02:04');

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

CREATE TABLE `history` (
  `ID` int(255) NOT NULL,
  `UserID` int(255) NOT NULL,
  `BorrowedID` int(255) NOT NULL,
  `ReturnedID` int(255) NOT NULL,
  `ItemID` int(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `Remarks` varchar(255) NOT NULL,
  `BorrowedDate` datetime NOT NULL DEFAULT current_timestamp(),
  `ReturnedRemarks` varchar(255) NOT NULL,
  `ReturnedDate` varchar(255) NOT NULL,
  `Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `history`
--

INSERT INTO `history` (`ID`, `UserID`, `BorrowedID`, `ReturnedID`, `ItemID`, `Category`, `ItemName`, `Description`, `Quantity`, `Remarks`, `BorrowedDate`, `ReturnedRemarks`, `ReturnedDate`, `Status`) VALUES
(3, 15, 0, 0, 10, 'Monitors', 'Crion', 'Crion Monitors', 5, 'Functional', '0000-00-00 00:00:00', '', '', ''),
(4, 15, 0, 0, 2, 'System Unit', 'Dell', '4 x 4', 5, 'Functional', '2024-01-03 17:13:15', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `ItemID` int(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `Remarks` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`ItemID`, `Category`, `ItemName`, `Description`, `Quantity`, `Remarks`) VALUES
(1, 'Tools', 'Screw Driver', 'None\r\n', 42, 'Functional'),
(2, 'Monitors', 'Dell', '4 x 4', 5, 'Functional'),
(3, 'System Unit', 'Dell', 'Ports not working', 2, 'Damage'),
(4, 'System Unit', 'Dell', 'Working', 12, 'Functional'),
(5, 'Monitors', 'Crion', 'None', 3, 'Return'),
(6, 'Keyboard\r\n', 'HP', 'High Quality', 10, 'Functional'),
(7, 'Mouse', 'Acer', 'None', 13, 'Functional'),
(8, 'Mouse', 'Hex\r\n', 'clinder mouse', 0, 'Functional'),
(9, 'Mouse', 'Hex', 'hex mouse', 0, 'Functional'),
(10, 'Monitors', 'Crion', 'Crion Monitors', 0, 'Functional'),
(11, 'Monitors', 'HP', 'Hp Monitors', 27, 'Functional');

-- --------------------------------------------------------

--
-- Table structure for table `returned`
--

CREATE TABLE `returned` (
  `ReturnedID` int(11) NOT NULL,
  `BorrowedID` int(255) NOT NULL,
  `ItemID` int(255) NOT NULL,
  `UserID` int(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `itemName` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `Remarks` varchar(255) NOT NULL,
  `dateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `returned`
--

INSERT INTO `returned` (`ReturnedID`, `BorrowedID`, `ItemID`, `UserID`, `Category`, `itemName`, `Description`, `Quantity`, `Remarks`, `dateTime`, `Status`) VALUES
(2, 5, 11, 18, 'Monitors', 'HP', 'None', 5, 'Functional', '2024-01-03 14:45:07', 'Confirmed'),
(4, 8, 10, 16, 'Monitors', 'Crion', 'Crion Monitors', 5, 'Functional', '2024-01-03 17:02:19', 'Confirmed'),
(5, 9, 10, 16, 'Monitors', 'Crion', 'Crion Monitors', 5, 'Functional', '2024-01-03 17:02:25', 'Confirmed'),
(6, 12, 1, 20, 'Tools', 'Screw Driver', 'None\r\n', 10, 'Functional', '2024-01-04 21:03:29', 'Confirmed'),
(7, 12, 1, 20, 'Tools', 'Screw Driver', 'None\r\n', 5, 'Functional', '2024-01-04 21:08:26', 'Confirmed');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `borrowed`
--
ALTER TABLE `borrowed`
  ADD PRIMARY KEY (`BorrowedID`);

--
-- Indexes for table `history`
--
ALTER TABLE `history`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `returned`
--
ALTER TABLE `returned`
  ADD PRIMARY KEY (`ReturnedID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `UserID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `borrowed`
--
ALTER TABLE `borrowed`
  MODIFY `BorrowedID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `history`
--
ALTER TABLE `history`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ItemID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `returned`
--
ALTER TABLE `returned`
  MODIFY `ReturnedID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
