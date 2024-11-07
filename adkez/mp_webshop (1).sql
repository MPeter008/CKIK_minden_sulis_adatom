-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Okt 08. 12:27
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
-- Adatbázis: `mp_webshop`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekek`
--

CREATE TABLE `termekek` (
  `azonosító` int(11) NOT NULL,
  `név` varchar(20) NOT NULL,
  `ár` int(11) NOT NULL,
  `raktáron` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `termekek`
--

INSERT INTO `termekek` (`azonosító`, `név`, `ár`, `raktáron`) VALUES
(1, 'Billentyűzet', 30, 10);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vásárlás`
--

CREATE TABLE `vásárlás` (
  `azonosító` int(11) NOT NULL,
  `termék_azonosító` int(11) NOT NULL,
  `vásárló_azonosító` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vásárló`
--

CREATE TABLE `vásárló` (
  `azonosító` int(11) NOT NULL,
  `név` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `termekek`
--
ALTER TABLE `termekek`
  ADD PRIMARY KEY (`azonosító`);

--
-- A tábla indexei `vásárlás`
--
ALTER TABLE `vásárlás`
  ADD PRIMARY KEY (`azonosító`),
  ADD KEY `termék_azonosító` (`termék_azonosító`,`vásárló_azonosító`),
  ADD KEY `vásárló_azonosító` (`vásárló_azonosító`);

--
-- A tábla indexei `vásárló`
--
ALTER TABLE `vásárló`
  ADD PRIMARY KEY (`azonosító`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `termekek`
--
ALTER TABLE `termekek`
  MODIFY `azonosító` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT a táblához `vásárlás`
--
ALTER TABLE `vásárlás`
  MODIFY `azonosító` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `vásárló`
--
ALTER TABLE `vásárló`
  MODIFY `azonosító` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vásárlás`
--
ALTER TABLE `vásárlás`
  ADD CONSTRAINT `vásárlás_ibfk_1` FOREIGN KEY (`termék_azonosító`) REFERENCES `termekek` (`azonosító`) ON UPDATE CASCADE,
  ADD CONSTRAINT `vásárlás_ibfk_2` FOREIGN KEY (`vásárló_azonosító`) REFERENCES `vásárló` (`azonosító`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;