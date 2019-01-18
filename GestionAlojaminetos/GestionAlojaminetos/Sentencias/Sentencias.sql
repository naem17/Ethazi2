SELECT `FIRMA`, `NOMBRE`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA, 1, 50),'...') AS `DESCRIPCION ABREVIADA`, `TIENDA`,`ID_RELACIONES` AS `ID RELACIONES`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGO TIPOS`, `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA_EUSKERA, 1, 50),'...') AS `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(DESCRIPCION, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(DESCRIPCION_EUSKERA, 1, 50),'...') AS `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA` FROM `alojamientos` ORDER BY `NOMBRE`

UPDATE `alojamientos` SET `NOMBRE` = ?, `DESCRIPCION_ABREVIADA` = ?, `TIENDA` = ?, `ID_RELACIONES` = ?, `CAPACIDAD` = ?, `GASTRONOMICO` = ?, `SURFING` = ?, `COORDENADAS` = ?, `CODIGO_TIPOS` = ?, `CODIGO_TIPOS_EUSKERA` = ?, `CODIGO_CATEGORIAS` = ?, `DESCRIPCION_ABREVIADA_EUSKERA` = ?, `DESCRIPCION` = ?, `DESCRIPCION_EUSKERA` = ?, `TELEFONO` = ?, `DIRECCION` = ?, `CALIDAD_ASEGURADA` = ?, `WEB` = ?, `EMAIL` = ?, `CLUB` = ?, `RESTAURANTE` = ?, `AUTOCARAVANA` = ? WHERE `FIRMA` = ?

INSERT INTO `alojamientos` (`FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA`, `TIENDA`, `ID_RELACIONES`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS`, `CODIGO_TIPOS_EUSKERA`, `CODIGO_CATEGORIAS`, `DESCRIPCION_ABREVIADA_EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA`, `WEB`, `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)

DELETE FROM `alojamientos` WHERE `FIRMA` = ?

SELECT `FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, `DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, `EMAIL`, `WEB`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`, `TIENDA`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGOS TIPOS`, `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, `ID_RELACIONES` AS `ID RELACIONES` FROM `alojamientos` WHERE `FIRMA` = @param

SELECT A.`FIRMA`, A.`NOMBRE`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, A.`CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA_EUSKERA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P WHERE A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`

SELECT A.`FIRMA`, A.`NOMBRE`, A.`DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, A.`CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, A.`DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P WHERE A.`FIRMA` = @param AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE`

SELECT `FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, `DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, `EMAIL`, `WEB`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`, `TIENDA`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGOS TIPOS`, `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, `ID_RELACIONES` AS `ID RELACIONES` FROM `alojamientos` WHERE `FIRMA` = @param

SELECT A.`FIRMA`, A.`NOMBRE`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, K.`CATEGORIA`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA_EUSKERA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`

SELECT A.`FIRMA`, A.`NOMBRE`, A.`DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, A.`CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, A.`DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P WHERE A.`FIRMA` = @param AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE`