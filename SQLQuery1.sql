



create database petHome

use petHome


create table USUARIO(
	IdUsuario int primary key identity(1,1),
	Correo varchar(100),
	Clave varchar(300)
)

create proc sp_RegistrarUsuario(
	@Correo varchar(100),
	@Clave varchar(300),
	@Registrado bit output,
	@Mensaje varchar(100) output
)
as
begin

	if(not exists(select * from USUARIO where Correo = @Correo))
	begin
		insert into USUARIO(Correo, Clave) values(@Correo, @Clave)
		set @Registrado = 1
		set @Mensaje = 'Usuario Registrado'
	end
	else
	begin
		set @Registrado = 0
		set @Mensaje = 'Correo ya existe'
	end

end


create proc sp_ValidarUsuario(
@Correo varchar(100),
@Clave varchar(300)
)

as
begin
	if(exists(select * from USUARIO where Correo = @Correo and Clave = @Clave))
		select IdUsuario from USUARIO where Correo = @Correo and Clave = @Clave
	else
		select '0'
end


declare @Registrado bit, @Mensaje varchar(100)

exec sp_RegistrarUsuario 'josias@gmail.com', 'fecf01159b4a102686e42bdc5bb514efdb350a3afb376a3cb77c6b3ff0ba5f92', @Registrado output, @Mensaje output

select @Registrado
select @Mensaje

select * from USUARIO

exec sp_ValidarUsuario 'josias@gmail.com', 'fecf01159b4a102686e42bdc5bb514efdb350a3afb376a3cb77c6b3ff0ba5f92'            