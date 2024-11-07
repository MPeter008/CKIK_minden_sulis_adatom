-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Okt 15. 12:27
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
-- Adatbázis: `mp_kutyak`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gazda`
--

CREATE TABLE `gazda` (
  `ID` int(11) NOT NULL,
  `nev` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gazdaja`
--

CREATE TABLE `gazdaja` (
  `KutyaID` int(11) NOT NULL,
  `GazdaID` int(11) NOT NULL,
  `ÖrökbeFogadásDátuma` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kutya`
--

CREATE TABLE `kutya` (
  `ID` int(11) NOT NULL,
  `nev` varchar(20) NOT NULL,
  `kor` int(11) NOT NULL
) ;

--
-- A tábla adatainak kiíratása `kutya`
--

INSERT INTO `kutya` (`ID`, `nev`, `kor`) VALUES
(1, 'Zeus', 5);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `gazda`
--
ALTER TABLE `gazda`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `gazdaja`
--
ALTER TABLE `gazdaja`
  ADD KEY `KutyaID` (`KutyaID`,`GazdaID`),
  ADD KEY `GazdaID` (`GazdaID`);

--
-- A tábla indexei `kutya`
--
ALTER TABLE `kutya`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `gazda`
--
ALTER TABLE `gazda`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `kutya`
--
ALTER TABLE `kutya`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `gazdaja`
--
ALTER TABLE `gazdaja`
  ADD CONSTRAINT `gazdaja_ibfk_1` FOREIGN KEY (`GazdaID`) REFERENCES `kutya` (`ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `gazdaja_ibfk_2` FOREIGN KEY (`KutyaID`) REFERENCES `gazda` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
