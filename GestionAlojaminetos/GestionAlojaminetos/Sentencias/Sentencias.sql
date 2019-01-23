/*DELETE PARA ALOJAMIENTOS*/
DELETE FROM `alojamientos` WHERE `FIRMA` = ?

/*SELECT PARA LA PAGINA ALOJAMIENTOS*/
SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`

/*SELECT DE AL PAGINA VER SELECCION*/
SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`FIRMA` = @param AND A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`

/*SELECT DE LAS CATEGORIAS*/
SELECT `CATEGORIA` FROM `CATEGORIAS`

/*SELECT DE LOS TIPOS*/
SELECT `TIPO` FROM `TIPOS`

/*SELECT DE LOS TIPOS EUSKERA*/
SELECT `TIPO_EUSKERA` FROM `TIPOS_EUSKERA`

/*SELECT DE LAS PROVINCIAS*/
SELECT `PROVINCUA` FROM `PROVINCIAS`

/*SELECT DE LOS MUNICIPIOS DEPENDIENDO DE LA PROVINCIA*/
SELECT `MUNICIPIO` FROM `MUNICIPIOS` WHERE `INDICE` IN (SELECT `INDICE_MUNICIPIO` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` WHERE `CODIGO_PROVINCIA` = '@param')

/*SELECT DEL INDICE DE MUNICIPIOS USANDO EL MUNICIPIO*/
SELECT `INDICE` FROM `MUNICIPIOS` WHERE `MUNICIPIO` = @param

/*SELECT DE LOS CODIGOS_POSTALES*/
SELECT * FROM `CODIGOS_POSTALES` WHERE `CODIGO_POSTAL` IN (SELECT R.`CODIGO_POSTAL` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` R WHERE `INDICE_MUNICIPIO` IN (@param)) ORDER BY `CODIGO_POSTAL` ASC

/*SELECT DEL CODIGO DEL LOS TIPOS USANDO COMO CONDICION EL TIPO*/
SELECT `CODIGO` FROM `TIPOS` WHERE `TIPO` = @param

/*INSERT DE UN REGISTRO*/
INSERT INTO `alojamientos` (`FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA`, `DESCRIPCION_ABREVIADA_EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA`, `EMAIL`, `WEB`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`, `TIENDA`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS`, `CODIGO_TIPOS_EUSKERA`, `CODIGO_CATEGORIAS`, `ID_RELACIONES`) VALUES ('AAAAAAAA', 'AAAAAAAAAAAAAA', 'AAAAAAAAAAAAAA', 'AAAAAAAAAAAAA', 'AAAAAAAAAAAAA', 'AAAAAAAAAAAAA', 'AAAAAAA', 'AAAAAAAAAAAA', '1', 'AAAAAAAAAA', 'AAAAAAAAAAAAAAA', '1', '1', '1', '1', '12', '1', '1', 'AAAAAAAAAAAAAAAAAAAAAAA', '2', '2', '2', '103');