--Llamada a procedimiento almacenado

Select * from Nomina

--exec [dbo].[CECYTE_Nomina] @a�o, @quincena

exec [dbo].[CECYTE_Nomina] 2022, 1