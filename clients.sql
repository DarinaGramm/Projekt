-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Erstellungszeit: 02. Jun 2023 um 17:52
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
  `title` varchar(4) NOT NULL,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `date_of_birth` date NOT NULL,
  `telephone_number` varchar(14) NOT NULL,
  `e-mail` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `clients`
--

INSERT INTO `clients` (`client_id`, `title`, `name`, `surname`, `date_of_birth`, `telephone_number`, `e-mail`) VALUES
(1, 'Herr', 'Max', 'Mühler', '1996-03-17', '015136952258', 'max@mail.com'),
(2, 'Frau', 'Maria', 'Muster', '1998-11-19', '015122583456', 'maria@mail.com');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`client_id`),
  ADD UNIQUE KEY `id` (`client_id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `clients`
--
ALTER TABLE `clients`
  MODIFY `client_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
