--Llamada a procedimiento almacenado

Select * from Nomina

--exec [dbo].[CECYTE_Nomina] @año, @quincena

exec [dbo].[CECYTE_Nomina] 2022, 1