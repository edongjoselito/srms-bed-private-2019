-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2023 at 10:46 PM
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
-- Database: `srms_bed`
--
CREATE DATABASE IF NOT EXISTS `srms_bed` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `srms_bed`;

-- --------------------------------------------------------

--
-- Table structure for table `course_table`
--

CREATE TABLE `course_table` (
  `courseid` int(11) NOT NULL,
  `CourseCode` varchar(45) NOT NULL,
  `CourseDescription` varchar(45) NOT NULL,
  `Major` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `course_table`
--

INSERT INTO `course_table` (`courseid`, `CourseCode`, `CourseDescription`, `Major`) VALUES
(1, 'ELEM', 'Elementary', 'Grade 01'),
(3, 'sfsdfda', 'dfa', 'dfadffsd'),
(4, 'ELEM', 'Elementary', 'Grade 02'),
(5, 'SHS', 'Senior High School', 'Grade 11'),
(6, 'JHS', 'Junior High School', 'Grade 07');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id` int(11) NOT NULL,
  `subjectCode` varchar(45) NOT NULL,
  `description` varchar(100) NOT NULL,
  `yearLevel` varchar(45) NOT NULL,
  `course` varchar(65) NOT NULL,
  `sem` varchar(65) NOT NULL,
  `subCategory` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`id`, `subjectCode`, `description`, `yearLevel`, `course`, `sem`, `subCategory`) VALUES
(1, 'Math 07', 'Mathematics 07', 'Grade 07', 'Junior High School', 'Second Semester', 'Core');

-- --------------------------------------------------------

--
-- Table structure for table `track_strand`
--

CREATE TABLE `track_strand` (
  `trackID` int(11) NOT NULL,
  `track` varchar(75) NOT NULL,
  `strand` varchar(75) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `track_strand`
--

INSERT INTO `track_strand` (`trackID`, `track`, `strand`) VALUES
(1, 'Track', 'Strand'),
(2, 'Academic', 'GAS');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course_table`
--
ALTER TABLE `course_table`
  ADD PRIMARY KEY (`courseid`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `track_strand`
--
ALTER TABLE `track_strand`
  ADD PRIMARY KEY (`trackID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course_table`
--
ALTER TABLE `course_table`
  MODIFY `courseid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `track_strand`
--
ALTER TABLE `track_strand`
  MODIFY `trackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
