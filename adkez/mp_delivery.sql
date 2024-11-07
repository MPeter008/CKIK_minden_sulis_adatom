-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Nov 06. 09:29
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
-- Adatbázis: `mp_delivery`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partner`
--

CREATE TABLE `partner` (
  `Name` varchar(40) NOT NULL,
  `Service` varchar(40) NOT NULL,
  `Cost` int(11) NOT NULL
) ;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `project`
--

CREATE TABLE `project` (
  `Name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `supplier`
--

CREATE TABLE `supplier` (
  `Name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `supply`
--

CREATE TABLE `supply` (
  `Contract` int(11) NOT NULL,
  `Supplier_Name` varchar(40) NOT NULL,
  `Partner_Name` varchar(40) NOT NULL,
  `Project_Name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`Name`);

--
-- A tábla indexei `project`
--
ALTER TABLE `project`
  ADD PRIMARY KEY (`Name`);

--
-- A tábla indexei `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Name`);

--
-- A tábla indexei `supply`
--
ALTER TABLE `supply`
  ADD PRIMARY KEY (`Contract`),
  ADD KEY `Partner_Name` (`Partner_Name`),
  ADD KEY `Supplier_Name` (`Supplier_Name`),
  ADD KEY `Project_Name` (`Project_Name`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `supply`
--
ALTER TABLE `supply`
  ADD CONSTRAINT `supply_ibfk_1` FOREIGN KEY (`Supplier_Name`) REFERENCES `supplier` (`Name`),
  ADD CONSTRAINT `supply_ibfk_2` FOREIGN KEY (`Partner_Name`) REFERENCES `partner` (`Name`),
  ADD CONSTRAINT `supply_ibfk_3` FOREIGN KEY (`Project_Name`) REFERENCES `project` (`Name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
