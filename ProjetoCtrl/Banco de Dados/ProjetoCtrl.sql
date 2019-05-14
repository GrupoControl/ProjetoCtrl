use ProjetoCtrl;

create table TbCarro
(
	id_car integer identity(1,1) not null,
	marca_car varchar(100),
	modelo_car varchar(100),
	ano_car integer,
	combustivel_car varchar(100),
	quilometragem_car decimal(20,0),
	cambio_car varchar(100),
	blindado_car varchar(30),
	cor_car varchar(100),
	preco_car decimal(20,2),
	constraint pk_id_car primary key(id_car)
);

insert into TbCarro values ('Chevroltet', 'Celta', 2010, 'Álcool e Gasolina', 59600, 'Manual', 'Sem Blindagem', 'Preto', 17500.00)
insert into TbCarro values ('Fiat', 'Uno', 2019, 'Álcool e Gasolina', 10000, 'Manual', 'Sem Blindagem', 'Branco', 27500.00)
insert into TbCarro values ('Volkswagen', 'Gol', 2000, 'Álcool', 90555, 'Manual', 'Sem Blindagem', 'Branco', 12500.00)
insert into TbCarro values ('Volkswagen', 'Fusca', 1950, 'Gasolina', 200000, 'Manual', 'Sem Blindagem', 'Bege',8200.00)
insert into TbCarro values ('Volkswagen', 'Brasília', 1951, 'Gasolina', 147888, 'Manual', 'Sem Blindagem', 'Bronze', 7300.00)
insert into TbCarro values ('Toyota', 'Hilux SW4', 2019, 'Álcool e Gasolina', 2000, 'Semi-Automático', 'Com Blindagem', 'Prata', 89500.00)
insert into TbCarro values ('Ford', 'Ranger', 2010, 'Álcool e Gasolina', 60443, 'Automático', 'Com Blindagem', 'Preto', 58450.00)
insert into TbCarro values ('Renault', 'Duster', 2019, 'Álcool e Gasolina', 1500, 'Automático', 'Sem Blindagem', 'Vermelho', 85500.00)
insert into TbCarro values ('Fiat', 'Fiorino', 1998, 'Gasolina', 105400, 'Manual', 'Sem Blindagem', 'Cinza', 13400.00)
insert into TbCarro values ('Mitsubishi', 'Pajero Dakar', 2017, 'Álcool', 12400, 'Semi-Automático', 'Com Blindagem', 'Vinho', 110000.00)



drop table TbCarro

create table TbMarcaCar
(
	id_marca integer primary key,
	marcaCar varchar(100),
);

insert into TbMarcaCar values (1, 'Chevroltet');
insert into TbMarcaCar values (2, 'Citroen');
insert into TbMarcaCar values (3, 'Fiat');
insert into TbMarcaCar values (4, 'Ford');
insert into TbMarcaCar values (5, 'Honda');
insert into TbMarcaCar values (6, 'Hyundai');
insert into TbMarcaCar values (7, 'Mitsubishi');
insert into TbMarcaCar values (8, 'Nissan');
insert into TbMarcaCar values (9, 'Peugeot');
insert into TbMarcaCar values (10, 'Renault');
insert into TbMarcaCar values (11, 'Toyota');
insert into TbMarcaCar values (12, 'Volkswagen');

drop table TbMarcaCar

create table TbModeloCar
(
	id_modelo integer primary key,
	marca varchar(100),
	modelo varchar(30)
);

insert into TbModeloCar values (1, 'Chevroltet', 'Astra');
insert into TbModeloCar values (2, 'Chevroltet', 'Camaro');
insert into TbModeloCar values (3, 'Chevroltet', 'Celta');
insert into TbModeloCar values (4, 'Chevroltet', 'Chevette');
insert into TbModeloCar values (5, 'Chevroltet', 'Classic');
insert into TbModeloCar values (6, 'Chevroltet', 'Corsa');
insert into TbModeloCar values (7, 'Chevroltet', 'Malibu');
insert into TbModeloCar values (8, 'Chevroltet', 'Monza');
insert into TbModeloCar values (9, 'Chevroltet', 'Omega');
insert into TbModeloCar values (10, 'Chevroltet', 'Onix');
insert into TbModeloCar values (11, 'Chevroltet', 'Opala');
insert into TbModeloCar values (12, 'Chevroltet', 'Pickup');
insert into TbModeloCar values (13, 'Chevroltet', 'Prisma');
insert into TbModeloCar values (14, 'Chevroltet', 'Silverado');
insert into TbModeloCar values (15, 'Chevroltet', 'Vectra');
insert into TbModeloCar values (16, 'Citroen', 'Aircross');
insert into TbModeloCar values (17, 'Citroen', 'C2');
insert into TbModeloCar values (18, 'Citroen', 'C3');
insert into TbModeloCar values (19, 'Citroen', 'C3 Picasso');
insert into TbModeloCar values (20, 'Citroen', 'C3 Sonora');
insert into TbModeloCar values (21, 'Citroen', 'C4');
insert into TbModeloCar values (22, 'Citroen', 'C4 Cactus');
insert into TbModeloCar values (23, 'Citroen', 'C4 Grand Picasso');
insert into TbModeloCar values (24, 'Citroen', 'C4 Lounge');
insert into TbModeloCar values (25, 'Citroen', 'C4 Picasso');
insert into TbModeloCar values (26, 'Citroen', 'C5');
insert into TbModeloCar values (27, 'Citroen', 'C6');
insert into TbModeloCar values (28, 'Citroen', 'C8');
insert into TbModeloCar values (29, 'Fiat', 'Bravo');
insert into TbModeloCar values (30, 'Fiat', 'Cronos');
insert into TbModeloCar values (31, 'Fiat', 'Ducato');
insert into TbModeloCar values (32, 'Fiat', 'Fiorino');
insert into TbModeloCar values (33, 'Fiat', 'Idea');
insert into TbModeloCar values (34, 'Fiat', 'Linea');
insert into TbModeloCar values (35, 'Fiat', 'Marea');
insert into TbModeloCar values (36, 'Fiat', 'Pálio');
insert into TbModeloCar values (37, 'Fiat', 'Punto');
insert into TbModeloCar values (38, 'Fiat', 'Siena');
insert into TbModeloCar values (39, 'Fiat', 'Strada');
insert into TbModeloCar values (40, 'Fiat', 'Uno');
insert into TbModeloCar values (41, 'Ford', 'Belina');
insert into TbModeloCar values (42, 'Ford', 'Del Rey');
insert into TbModeloCar values (43, 'Ford', 'EcoSport');
insert into TbModeloCar values (44, 'Ford', 'Edge');
insert into TbModeloCar values (45, 'Ford', 'Escort');
insert into TbModeloCar values (46, 'Ford', 'Focus');
insert into TbModeloCar values (47, 'Ford', 'Fusion');
insert into TbModeloCar values (48, 'Ford', 'Jeep');
insert into TbModeloCar values (49, 'Ford', 'Ka');
insert into TbModeloCar values (50, 'Ford', 'Ka +');
insert into TbModeloCar values (51, 'Ford', 'Maverick');
insert into TbModeloCar values (52, 'Ford', 'Mustang');
insert into TbModeloCar values (53, 'Ford', 'Pampa');
insert into TbModeloCar values (54, 'Ford', 'Ranger');
insert into TbModeloCar values (55, 'Honda', 'City');
insert into TbModeloCar values (56, 'Honda', 'Civic');
insert into TbModeloCar values (57, 'Honda', 'Fit');
insert into TbModeloCar values (58, 'Honda', 'Legend');
insert into TbModeloCar values (59, 'Honda', 'S2000');
insert into TbModeloCar values (60, 'Honda', 'S800');
insert into TbModeloCar values (61, 'Hyundai', 'Azera');
insert into TbModeloCar values (62, 'Hyundai', 'Creta');
insert into TbModeloCar values (63, 'Hyundai', 'Grand Santa Fé');
insert into TbModeloCar values (64, 'Hyundai', 'HB20');
insert into TbModeloCar values (65, 'Hyundai', 'HB20S');
insert into TbModeloCar values (66, 'Hyundai', 'HB20X');
insert into TbModeloCar values (67, 'Hyundai', 'Santa Fé');
insert into TbModeloCar values (68, 'Hyundai', 'Sonata');
insert into TbModeloCar values (69, 'Hyundai', 'Tucson');
insert into TbModeloCar values (70, 'Hyundai', 'Veloster');
insert into TbModeloCar values (71, 'Hyundai', 'Veracruz');
insert into TbModeloCar values (72, 'Mitsubishi', '3000 GT');
insert into TbModeloCar values (73, 'Mitsubishi', 'Eclipse');
insert into TbModeloCar values (74, 'Mitsubishi', 'Pajero');
insert into TbModeloCar values (75, 'Mitsubishi', 'Pajero Dakar');
insert into TbModeloCar values (76, 'Mitsubishi', 'Pajero Full');
insert into TbModeloCar values (77, 'Mitsubishi', 'Pajeto IO');
insert into TbModeloCar values (78, 'Mitsubishi', 'Pajero Sport');
insert into TbModeloCar values (79, 'Mitsubishi', 'Raider');
insert into TbModeloCar values (80, 'Nissan', '240SX');
insert into TbModeloCar values (81, 'Nissan', '280Z');
insert into TbModeloCar values (82, 'Nissan', '350Z');
insert into TbModeloCar values (83, 'Nissan', '370Z');
insert into TbModeloCar values (84, 'Nissan', 'Altima');
insert into TbModeloCar values (85, 'Nissan', 'Livina');
insert into TbModeloCar values (86, 'Nissan', 'March');
insert into TbModeloCar values (87, 'Nissan', 'Sentra');
insert into TbModeloCar values (88, 'Nissan', 'Versa');
insert into TbModeloCar values (89, 'Peugeot', '106');
insert into TbModeloCar values (90, 'Peugeot', '205');
insert into TbModeloCar values (91, 'Peugeot', '206');
insert into TbModeloCar values (92, 'Peugeot', '207');
insert into TbModeloCar values (93, 'Peugeot', '208');
insert into TbModeloCar values (94, 'Peugeot', '306');
insert into TbModeloCar values (95, 'Peugeot', '307');
insert into TbModeloCar values (96, 'Peugeot', '308');
insert into TbModeloCar values (97, 'Peugeot', '309');
insert into TbModeloCar values (98, 'Peugeot', '405');
insert into TbModeloCar values (99, 'Peugeot', '406');
insert into TbModeloCar values (100, 'Peugeot', '407');
insert into TbModeloCar values (101, 'Peugeot', '408');
insert into TbModeloCar values (102, 'Peugeot', '504');
insert into TbModeloCar values (103, 'Peugeot', '505');
insert into TbModeloCar values (104, 'Peugeot', 'Boxer');
insert into TbModeloCar values (105, 'Renault', 'Duster');
insert into TbModeloCar values (106, 'Renault', 'Fluence');
insert into TbModeloCar values (107, 'Renault', 'Logan');
insert into TbModeloCar values (108, 'Renault', 'Mégane');
insert into TbModeloCar values (109, 'Renault', 'Sandero');
insert into TbModeloCar values (110, 'Toyota', 'Corolla');
insert into TbModeloCar values (111, 'Toyota', 'Corona');
insert into TbModeloCar values (112, 'Toyota', 'Etios');
insert into TbModeloCar values (113, 'Toyota', 'Hilux');
insert into TbModeloCar values (114, 'Toyota', 'Hilux SW4');
insert into TbModeloCar values (115, 'Toyota', 'T-100');
insert into TbModeloCar values (116, 'Toyota', 'Tundra');
insert into TbModeloCar values (117, 'Volkswagen', 'Amarok');
insert into TbModeloCar values (118, 'Volkswagen', 'Apollo');
insert into TbModeloCar values (119, 'Volkswagen', 'Bora');
insert into TbModeloCar values (120, 'Volkswagen', 'Brasília');
insert into TbModeloCar values (121, 'Volkswagen', 'CrossFox');
insert into TbModeloCar values (122, 'Volkswagen', 'Fox');
insert into TbModeloCar values (123, 'Volkswagen', 'Fusca');
insert into TbModeloCar values (124, 'Volkswagen', 'Gol');
insert into TbModeloCar values (125, 'Volkswagen', 'Golf');
insert into TbModeloCar values (126, 'Volkswagen', 'Jetta');
insert into TbModeloCar values (127, 'Volkswagen', 'Parati');
insert into TbModeloCar values (128, 'Volkswagen', 'Polo');
insert into TbModeloCar values (129, 'Volkswagen', 'Santana');
insert into TbModeloCar values (130, 'Volkswagen', 'Saveiro');
insert into TbModeloCar values (131, 'Volkswagen', 'SpaceFox');
insert into TbModeloCar values (132, 'Volkswagen', 'Voyage');


drop table TbModeloCar



drop table MarcaCar

create table TbMoto
(
	id_mot integer identity(1,1) not null,
	marca_mot varchar(100),
	modelo_mot varchar(100),
	ano_mot integer,
	combustivel_mot varchar(30),
	tipoPartida_mot varchar(100),
	tipoAlimentacao_mot varchar(100),
	tipoRefrigeracao_mot varchar(100),
	tipoFreio_mot varchar(100),
	qtdMarchas_mot integer,
	quilometragem_mot decimal(20,0),
	cor_mot varchar(100),
	preco_mot decimal(20,2),
	constraint pk_id_mot primary key(id_mot)
);

insert into TbMoto values ('Harley-Davidson', 'V-Rod Muscle', 2019, 'Álcool e Gasolina', 'Pedal e Elétrica', 'Injeção Eletrônica', 'Ar', N'Disco/Disco', 6, 10300, 'Preto', 55550.00)
insert into TbMoto values ('Honda', 'CG 150 Fan', 2019, 'Álcool e Gasolina', 'Elétrica', 'Injeção Eletrônica', 'Líquida', 'Tambor/Disco', 5, 20430, 'Azul', 6500.00)
insert into TbMoto values ('Honda', 'CG 160 Titan EX', 2014, 'Álcool e Gasolina', 'Pedal', 'Carburador', 'Ar', 'Tambor/Tambor', 5, 55000, 'Branco', 5450.00)
insert into TbMoto values ('Kawasaki', 'Ninja 1000', 2003, 'Gasolina', 'Pedal', 'Carburador', 'Ar', 'Tambor/Disco', 6, 110350, 'Azul',15300.00)
insert into TbMoto values ('Yamaha', 'Crypton 100', 2011, 'Álcool e Gasolina', 'Pedal', 'Carburador', 'Ar', 'Disco/Disco', 4, 68200, 'Vermelho', 3500.00)
insert into TbMoto values ('Suzuki', 'Bandit 1250S', 2014, 'Gasolina', 'Elétrica', 'Injeção Eletrônica', 'Líquida', 'Disco/Tambor', 6, 89230, 'Verde', 17300.00)
insert into TbMoto values ('Suzuki', 'Intruder 250', 2016, 'Gasolina', 'Elétrica', 'Injeção Eletrônica', 'Líquida', 'Tambor/Tambor', 5, 35300, 'Dourado', 16400.00)
insert into TbMoto values ('Ducati', 'Monster 1200 S', 2017, 'Álcool e Gasolina', 'Elétrica', 'Carburador', 'Ar', 'Tambor/Tambor', 6, 25300, 'Prata', 26200.00)

drop table TbMoto

create table TbMarcaMoto
(
	id_marca integer primary key,
	marca_mot varchar(100),
);

insert into TbMarcaMoto values (1, 'BMW');
insert into TbMarcaMoto values (2, 'Dafra');
insert into TbMarcaMoto values (3, 'Ducati');
insert into TbMarcaMoto values (4, 'Harley-Davidson');
insert into TbMarcaMoto values (5, 'Honda');
insert into TbMarcaMoto values (6, 'Kasinski');
insert into TbMarcaMoto values (7, 'Kawasaki');
insert into TbMarcaMoto values (8, 'Suzuki');
insert into TbMarcaMoto values (9, 'Yamaha');

create table TbModeloMoto
(
	id_modelo integer primary key,
	marca_mot varchar(50),
	modelo_mot varchar(100)
);

insert into TbModeloMoto values (1, 'BMW', 'C 600 Sport');
insert into TbModeloMoto values (2, 'BMW', 'F 650');
insert into TbModeloMoto values (3, 'BMW', 'F 650 GS Dakar');
insert into TbModeloMoto values (4, 'BMW', 'F 700 GS Sport');
insert into TbModeloMoto values (5, 'BMW', 'K 1600 GTL Exclusive');
insert into TbModeloMoto values (6, 'BMW', 'S 1000 R');
insert into TbModeloMoto values (7, 'BMW', 'S 1000 XR');
insert into TbModeloMoto values (8, 'Dafra', 'Apache RTR 150');
insert into TbModeloMoto values (9, 'Dafra', 'CityClass 200i');
insert into TbModeloMoto values (10, 'Dafra', 'CityCom 300i');
insert into TbModeloMoto values (11, 'Dafra', 'CityCom S 300i ABS');
insert into TbModeloMoto values (12, 'Dafra', 'Horizon 150');
insert into TbModeloMoto values (13, 'Dafra', 'Horizon 250');
insert into TbModeloMoto values (14, 'Dafra', 'Kansas 150');
insert into TbModeloMoto values (15, 'Dafra', 'Kansas 250');
insert into TbModeloMoto values (16, 'Dafra', 'Next 250');
insert into TbModeloMoto values (17, 'Dafra', 'Next 300');
insert into TbModeloMoto values (18, 'Dafra', 'Speed 150');
insert into TbModeloMoto values (19, 'Ducati', '1299 Panigale ABS');
insert into TbModeloMoto values (20, 'Ducati', 'Diavel Dark');
insert into TbModeloMoto values (21, 'Ducati', 'Hypermotard 1100');
insert into TbModeloMoto values (22, 'Ducati', 'Monster 1100');
insert into TbModeloMoto values (23, 'Ducati', 'Monster 1100 S');
insert into TbModeloMoto values (24, 'Ducati', 'Monster 1200');
insert into TbModeloMoto values (25, 'Ducati', 'Monster 1200 S');
insert into TbModeloMoto values (26, 'Harley-Davidson', 'Bad Boy');
insert into TbModeloMoto values (27, 'Harley-Davidson', 'CBR 650F');
insert into TbModeloMoto values (28, 'Harley-Davidson', 'CVO Street Glide');
insert into TbModeloMoto values (29, 'Harley-Davidson', 'EG Road King Fuel Injection');
insert into TbModeloMoto values (30, 'Harley-Davidson', 'Road King');
insert into TbModeloMoto values (31, 'Harley-Davidson', 'Softail Fat Boy');
insert into TbModeloMoto values (32, 'Harley-Davidson', 'Softail Street Bob');
insert into TbModeloMoto values (33, 'Harley-Davidson', 'Sporster 1200 Custom CA Limited');
insert into TbModeloMoto values (34, 'Harley-Davidson', 'Street 750');
insert into TbModeloMoto values (35, 'Harley-Davidson', 'V-Rod');
insert into TbModeloMoto values (36, 'Harley-Davidson', 'V-Rod Muscle');
insert into TbModeloMoto values (37, 'Harley-Davidson', 'V-Rod Sport');
insert into TbModeloMoto values (38, 'Harley-Davidson', 'V-Rod X');
insert into TbModeloMoto values (39, 'Honda', '1200 Gold Wing');
insert into TbModeloMoto values (40, 'Honda', '1500 Gold Wing');
insert into TbModeloMoto values (41, 'Honda', 'Biz 125 ES');
insert into TbModeloMoto values (42, 'Honda', 'Biz 125 EX');
insert into TbModeloMoto values (43, 'Honda', 'Biz 125 KS');
insert into TbModeloMoto values (44, 'Honda', 'CB 300R');
insert into TbModeloMoto values (45, 'Honda', 'CB 600F Hornet');
insert into TbModeloMoto values (46, 'Honda', 'CB 650 Custom');
insert into TbModeloMoto values (47, 'Honda', 'CG 125');
insert into TbModeloMoto values (48, 'Honda', 'CG 125 Fan');
insert into TbModeloMoto values (49, 'Honda', 'CG 125 Titan');
insert into TbModeloMoto values (50, 'Honda', 'CG 150 Cargo');
insert into TbModeloMoto values (51, 'Honda', 'CG 150 Fan');
insert into TbModeloMoto values (52, 'Honda', 'CG 150 Titan ES');
insert into TbModeloMoto values (53, 'Honda', 'CG 160 Fan');
insert into TbModeloMoto values (54, 'Honda', 'CG 160 Titan EX');
insert into TbModeloMoto values (55, 'Honda', 'NXR 150 Bros ES');
insert into TbModeloMoto values (56, 'Honda', 'ST 1300 Pan European');
insert into TbModeloMoto values (57, 'Kasinski', 'Comet 150');
insert into TbModeloMoto values (58, 'Kasinski', 'Comet 250');
insert into TbModeloMoto values (59, 'Kasinski', 'Comet 650R');
insert into TbModeloMoto values (60, 'Kasinski', 'Cruise 125');
insert into TbModeloMoto values (61, 'Kasinski', 'CRZ 150');
insert into TbModeloMoto values (62, 'Kasinski', 'CRZ 150 SM');
insert into TbModeloMoto values (63, 'Kasinski', 'Mirage 150');
insert into TbModeloMoto values (64, 'Kasinski', 'Mirage 250');
insert into TbModeloMoto values (65, 'Kasinski', 'Mirage 650');
insert into TbModeloMoto values (66, 'Kawasaki', 'D Tracker 250 X');
insert into TbModeloMoto values (67, 'Kawasaki', 'KX 125');
insert into TbModeloMoto values (68, 'Kawasaki', 'KX 250');
insert into TbModeloMoto values (69, 'Kawasaki', 'KX 500');
insert into TbModeloMoto values (70, 'Kawasaki', 'Ninja 1000');
insert into TbModeloMoto values (71, 'Kawasaki', 'Ninja 1000 ABS');
insert into TbModeloMoto values (72, 'Kawasaki', 'Ninja 250R');
insert into TbModeloMoto values (73, 'Kawasaki', 'Ninja 300');
insert into TbModeloMoto values (74, 'Kawasaki', 'Ninja 300 ABS');
insert into TbModeloMoto values (75, 'Kawasaki', 'Ninja 400');
insert into TbModeloMoto values (76, 'Kawasaki', 'Ninja 650 ABS');
insert into TbModeloMoto values (77, 'Kawasaki', 'Ninja EX 500');
insert into TbModeloMoto values (78, 'Suzuki', 'AN650 Burgman');
insert into TbModeloMoto values (79, 'Suzuki', 'Bandit 1200S');
insert into TbModeloMoto values (80, 'Suzuki', 'Bandit 1250');
insert into TbModeloMoto values (81, 'Suzuki', 'Bandit 1250F');
insert into TbModeloMoto values (82, 'Suzuki', 'Bandit 1250S');
insert into TbModeloMoto values (83, 'Suzuki', 'Bandit 600S');
insert into TbModeloMoto values (84, 'Suzuki', 'Bandit 650');
insert into TbModeloMoto values (85, 'Suzuki', 'Bandit 650N');
insert into TbModeloMoto values (86, 'Suzuki', 'Bandit 650S');
insert into TbModeloMoto values (87, 'Suzuki', 'Boulevard C1500');
insert into TbModeloMoto values (88, 'Suzuki', 'Boulevard M1500R');
insert into TbModeloMoto values (89, 'Suzuki', 'Hayabusa GSX1300R');
insert into TbModeloMoto values (90, 'Suzuki', 'Intruder 250');
insert into TbModeloMoto values (91, 'Yamaha', 'Crypton 100');
insert into TbModeloMoto values (92, 'Yamaha', 'Factor 150E');
insert into TbModeloMoto values (93, 'Yamaha', 'Factor YBR 125 K');
insert into TbModeloMoto values (94, 'Yamaha', 'Factor YBR 125 K1');
insert into TbModeloMoto values (95, 'Yamaha', 'Fazer 150 UBS');
insert into TbModeloMoto values (96, 'Yamaha', 'Fazer 600');
insert into TbModeloMoto values (97, 'Yamaha', 'Fazer 600S');
insert into TbModeloMoto values (98, 'Yamaha', 'TRX 850');
insert into TbModeloMoto values (99, 'Yamaha', 'TX 650');
insert into TbModeloMoto values (100, 'Yamaha', 'WR 450F');


drop table TbMoto

select * from TbModeloMoto;

