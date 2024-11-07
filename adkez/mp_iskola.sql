-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Okt 22. 12:26
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `mp_iskola`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `meets`
--

CREATE TABLE `meets` (
  `ID` int(11) NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL,
  `student_ID` int(11) NOT NULL,
  `supervisor_ID` int(11) NOT NULL,
  `notes` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `project`
--

CREATE TABLE `project` (
  `title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `student`
--

CREATE TABLE `student` (
  `ID` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `gender` enum('Nő','Férfi','Ló') NOT NULL,
  `course` varchar(255) NOT NULL,
  `project_title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `supervise`
--

CREATE TABLE `supervise` (
  `project_title` varchar(255) NOT NULL,
  `supervisor_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `supervisor`
--

CREATE TABLE `supervisor` (
  `ID` int(11) NOT NULL,
  `név` varchar(30) NOT NULL,
  `gender` enum('Nő','Férfi','Ló') NOT NULL,
  `department` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `meets`
--
ALTER TABLE `meets`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `student_ID` (`student_ID`),
  ADD KEY `supervisor_ID` (`supervisor_ID`);

--
-- A tábla indexei `project`
--
ALTER TABLE `project`
  ADD PRIMARY KEY (`title`);

--
-- A tábla indexei `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `project_title` (`project_title`);

--
-- A tábla indexei `supervise`
--
ALTER TABLE `supervise`
  ADD KEY `project_title` (`project_title`),
  ADD KEY `supervisor_ID` (`supervisor_ID`);

--
-- A tábla indexei `supervisor`
--
ALTER TABLE `supervisor`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `meets`
--
ALTER TABLE `meets`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `student`
--
ALTER TABLE `student`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `supervisor`
--
ALTER TABLE `supervisor`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `meets`
--
ALTER TABLE `meets`
  ADD CONSTRAINT `meets_ibfk_1` FOREIGN KEY (`student_ID`) REFERENCES `student` (`ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `meets_ibfk_2` FOREIGN KEY (`supervisor_ID`) REFERENCES `supervisor` (`ID`) ON DELETE CASCADE;

--
-- Megkötések a táblához `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`project_title`) REFERENCES `project` (`title`) ON DELETE CASCADE;

--
-- Megkötések a táblához `supervise`
--
ALTER TABLE `supervise`
  ADD CONSTRAINT `supervise_ibfk_1` FOREIGN KEY (`project_title`) REFERENCES `project` (`title`) ON DELETE CASCADE,
  ADD CONSTRAINT `supervise_ibfk_2` FOREIGN KEY (`supervisor_ID`) REFERENCES `supervisor` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
