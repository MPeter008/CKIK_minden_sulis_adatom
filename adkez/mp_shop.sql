-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Nov 05. 12:22
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
-- Adatbázis: `mp_shop`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `chemical`
--

CREATE TABLE `chemical` (
  `Name` varchar(40) NOT NULL,
  `Formula` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `order`
--

CREATE TABLE `order` (
  `chName` varchar(40) NOT NULL,
  `suName` varchar(40) NOT NULL,
  `PurchaseDate` date NOT NULL,
  `Amount` int(11) NOT NULL,
  `TotalCost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `supplier`
--

CREATE TABLE `supplier` (
  `Name` varchar(40) NOT NULL,
  `Contact` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `chemical`
--
ALTER TABLE `chemical`
  ADD PRIMARY KEY (`Name`);

--
-- A tábla indexei `order`
--
ALTER TABLE `order`
  ADD KEY `chName` (`chName`),
  ADD KEY `suName` (`suName`);

--
-- A tábla indexei `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Name`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`chName`) REFERENCES `chemical` (`Name`),
  ADD CONSTRAINT `order_ibfk_2` FOREIGN KEY (`suName`) REFERENCES `supplier` (`Name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
