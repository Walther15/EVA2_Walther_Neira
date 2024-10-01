-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-09-2024 a las 00:32:01
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `registropersonas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comuna`
--

CREATE TABLE `comuna` (
  `ComunaID` int(11) NOT NULL,
  `NombreComuna` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_spanish2_ci;

--
-- Volcado de datos para la tabla `comuna`
--

INSERT INTO `comuna` (`ComunaID`, `NombreComuna`) VALUES
(1, 'Arica'),
(2, 'Camarones'),
(3, 'Putre'),
(4, 'General Lagos'),
(5, 'Iquique'),
(6, 'Alto Hospicio'),
(7, 'Pozo Almonte'),
(8, 'Camiña'),
(9, 'Colchane'),
(10, 'Huara'),
(11, 'Pica'),
(12, 'Antofagasta'),
(13, 'Mejillones'),
(14, 'Sierra Gorda'),
(15, 'Taltal'),
(16, 'Calama'),
(17, 'Ollagüe'),
(18, 'San Pedro de Atacama'),
(19, 'Tocopilla'),
(20, 'María Elena'),
(21, 'Copiapó'),
(22, 'Caldera'),
(23, 'Tierra Amarilla'),
(24, 'Chañaral'),
(25, 'Diego de Almagro'),
(26, 'Vallenar'),
(27, 'Alto del Carmen'),
(28, 'Freirina'),
(29, 'Huasco'),
(30, 'La Serena'),
(31, 'Coquimbo'),
(32, 'Andacollo'),
(33, 'La Higuera'),
(34, 'Paiguano'),
(35, 'Vicuña'),
(36, 'Illapel'),
(37, 'Canela'),
(38, 'Los Vilos'),
(39, 'Salamanca'),
(40, 'Ovalle'),
(41, 'Combarbalá'),
(42, 'Monte Patria'),
(43, 'Punitaqui'),
(44, 'Río Hurtado'),
(45, 'Valparaíso'),
(46, 'Casablanca'),
(47, 'Concón'),
(48, 'Juan Fernández'),
(49, 'Puchuncaví'),
(50, 'Quintero'),
(51, 'Viña del Mar'),
(52, 'Isla de Pascua'),
(53, 'Los Andes'),
(54, 'Calle Larga'),
(55, 'Rinconada'),
(56, 'San Esteban'),
(57, 'La Ligua'),
(58, 'Cabildo'),
(59, 'Papudo'),
(60, 'Petorca'),
(61, 'Zapallar'),
(62, 'Quillota'),
(63, 'Calera'),
(64, 'Hijuelas'),
(65, 'La Cruz'),
(66, 'Nogales'),
(67, 'San Antonio'),
(68, 'Algarrobo'),
(69, 'Cartagena'),
(70, 'El Quisco'),
(71, 'El Tabo'),
(72, 'Santo Domingo'),
(73, 'San Felipe'),
(74, 'Catemu'),
(75, 'Llaillay'),
(76, 'Panquehue'),
(77, 'Putaendo'),
(78, 'Santa María'),
(79, 'Quilpué'),
(80, 'Limache'),
(81, 'Olmué'),
(82, 'Villa Alemana'),
(83, 'Santiago'),
(84, 'Cerrillos'),
(85, 'Cerro Navia'),
(86, 'Conchalí'),
(87, 'El Bosque'),
(88, 'Estación Central'),
(89, 'Huechuraba'),
(90, 'Independencia'),
(91, 'La Cisterna'),
(92, 'La Florida'),
(93, 'La Granja'),
(94, 'La Pintana'),
(95, 'La Reina'),
(96, 'Las Condes'),
(97, 'Lo Barnechea'),
(98, 'Lo Espejo'),
(99, 'Lo Prado'),
(100, 'Macul'),
(101, 'Maipú'),
(102, 'Ñuñoa'),
(103, 'Pedro Aguirre Cerda'),
(104, 'Peñalolén'),
(105, 'Providencia'),
(106, 'Pudahuel'),
(107, 'Quilicura'),
(108, 'Quinta Normal'),
(109, 'Recoleta'),
(110, 'Renca'),
(111, 'San Joaquín'),
(112, 'San Miguel'),
(113, 'San Ramón'),
(114, 'Vitacura'),
(115, 'Puente Alto'),
(116, 'Pirque'),
(117, 'San José de Maipo'),
(118, 'Colina'),
(119, 'Lampa'),
(120, 'Tiltil'),
(121, 'San Bernardo'),
(122, 'Buin'),
(123, 'Calera de Tango'),
(124, 'Paine'),
(125, 'Otras Comunas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personas`
--

CREATE TABLE `personas` (
  `RUT` varchar(12) NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `Sexo` varchar(10) DEFAULT NULL,
  `Comuna` varchar(50) DEFAULT NULL,
  `Ciudad` varchar(50) DEFAULT NULL,
  `Observacion` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_spanish2_ci;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`RUT`, `Nombre`, `Apellido`, `Sexo`, `Comuna`, `Ciudad`, `Observacion`) VALUES
('176236418', 'Francisco Javier', 'Yañez Corrales', 'Masculino', 'Puente Alto', 'Santiago', 'Prueba de Registro 1'),
('176236419', 'Fco', 'Yanez', 'No especif', 'Pudahuel', 'Santiago', 'sadadsadsadsa'),
('24350600K', 'Fernanda Anaiís', 'Yañez Guajardo', 'Femenino', 'Providencia', 'Santiago', 'Prueba 2');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `comuna`
--
ALTER TABLE `comuna`
  ADD PRIMARY KEY (`ComunaID`);

--
-- Indices de la tabla `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`RUT`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `comuna`
--
ALTER TABLE `comuna`
  MODIFY `ComunaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=126;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
