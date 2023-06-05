-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Erstellungszeit: 26. Mai 2023 um 10:44
-- Server-Version: 5.7.24
-- PHP-Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `travel_agancy`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `clients`
--

CREATE TABLE `clients` (
  `client_id` int(11) UNSIGNED NOT NULL,
  `titel` varchar(4) NOT NULL,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `date_of_birth` date NOT NULL,
  `telephone_number` int(12) NOT NULL,
  `e-mail` varchar(45) NOT NULL,
  `travel_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `travels`
--

CREATE TABLE `travels` (
  `travel_id` int(11) UNSIGNED NOT NULL,
  `hotel_name` varchar(45) NOT NULL,
  `place` text NOT NULL,
  `price` int(11) NOT NULL,
  `client_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`client_id`),
  ADD UNIQUE KEY `id` (`client_id`),
  ADD UNIQUE KEY `reisenr` (`travel_id`),
  ADD KEY `reise_id` (`travel_id`);

--
-- Indizes für die Tabelle `travels`
--
ALTER TABLE `travels`
  ADD PRIMARY KEY (`travel_id`),
  ADD UNIQUE KEY `reisenr` (`travel_id`),
  ADD KEY `client_id` (`client_id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `clients`
--
ALTER TABLE `clients`
  MODIFY `client_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `travels`
--
ALTER TABLE `travels`
  MODIFY `travel_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `clients`
--
ALTER TABLE `clients`
  ADD CONSTRAINT `clients_ibfk_1` FOREIGN KEY (`travel_id`) REFERENCES `travels` (`travel_id`);

--
-- Constraints der Tabelle `travels`
--
ALTER TABLE `travels`
  ADD CONSTRAINT `travels_ibfk_1` FOREIGN KEY (`client_id`) REFERENCES `clients` (`client_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
