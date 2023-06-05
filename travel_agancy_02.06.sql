-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Erstellungszeit: 02. Jun 2023 um 17:46
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

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `travels`
--

CREATE TABLE `travels` (
  `travel_id` int(11) UNSIGNED NOT NULL,
  `hotel_name` varchar(45) NOT NULL,
  `place` text NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `travels`
--

INSERT INTO `travels` (`travel_id`, `hotel_name`, `place`, `price`) VALUES
(1, 'La Palma Jardin', 'Spanien, Los Llanos de Aridane', 640),
(2, 'Delphin Deluxe', 'Türkei, Türkische Riviera, Okurcalar', 713),
(3, 'Du Lac et Du Parc Grand Resort ', 'Italien, Oberitalienische Seen & Gardasee, Riva del Garda', 1024),
(4, 'Amari ', 'Griechenland, Chalkidiki, Metamorfosi', 587),
(5, 'Lyttos Beach', 'Griechenland, Kreta, Chersonissos', 1265),
(6, 'Royal Palms Beach Hotel', 'Sri Lanka, Sri Lanka, Kalutara', 917),
(7, 'Cenit', 'Spanien, Ibiza, Ibiza-Stadt', 842),
(8, 'Hotel Baía Azul', 'Portugal, Madeira, Funchal', 1138),
(9, 'Yigitalp', 'Türkei, Istanbul (Provinz), Istanbul', 474),
(10, 'Hilton Malta', 'Malta, Malta island, San Giljan', 1071),
(11, 'Horizon Beach Resort', 'Griechenland, Kos, Mastichari', 984),
(12, 'Conrad Dubai', 'Vereinigte Arabische Emirate, Dubai, Dubai', 1003),
(13, 'Hotel Parque Tropical', 'Spanien, Gran Canaria, Playa del Inglés', 728),
(14, 'The Grand Resort, Hurghada', 'Ägypten, Rotes Meer, Hurghada', 443),
(15, 'Delphin Diva', 'Türkei, Türkische Riviera, Lara', 1301),
(16, 'Royal Decameron Tafoukt Beach', 'Marokko, Atlantikküste, Agadir', 758),
(17, 'Grupotel Playa de Palma Suites & Spa', 'Spanien, Mallorca, Playa de Palma', 770),
(18, 'Paradis Palace', 'Tunesien, Hammamet & Umgebung, Hammamet', 513),
(19, 'AVANI Victoria Falls Resort ', 'Sambia, Sambia, Livingstone', 2447),
(20, 'Comfort Suites Paradise Island', 'Bahamas, Bahamas, Paradise Island', 1992),
(21, 'Kempinski Seychelles Resort Baie Lazare', 'Seychellen, Insel Mahé, Baie Lazare', 1851),
(22, 'PortoBay Rio de Janeiro', 'Brasilien, Südosten, Rio de Janeiro', 1640),
(23, 'Windhoek Country Club Resort', 'Namibia, Namibia, Windhoek', 1552),
(24, 'Best Western Hotel President ', 'Italien, Latium, Rom', 819),
(25, 'Hilton Hawaiian Village Waikiki Beach Resort ', 'USA, Hawaii, Waikiki', 2114),
(26, 'Holiday Suites Across From Universal Orlando', 'USA, Florida, Orlando', 939),
(27, 'Terme Helvetia ', 'Italien, Venetien, Abano Terme', 555);

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
-- Indizes für die Tabelle `travels`
--
ALTER TABLE `travels`
  ADD PRIMARY KEY (`travel_id`),
  ADD UNIQUE KEY `reisenr` (`travel_id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `clients`
--
ALTER TABLE `clients`
  MODIFY `client_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT für Tabelle `travels`
--
ALTER TABLE `travels`
  MODIFY `travel_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
