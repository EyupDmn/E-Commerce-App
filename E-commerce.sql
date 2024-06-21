create database e_ticaret;
use e_ticaret;

create table kullanicilar(
	id varchar(64) primary key,
	ad_soyad varchar(110),
	eposta varchar(100),
	numara varchar(11),
	sifre varchar(80),
	adres varchar(200)
);

create table urunler(
	id varchar(64) primary key,
	ad varchar(80),
	fiyat varchar(11)
);


insert into urunler values('1da68626-2c33-4927-95a8-d1733b937a14', 'Bilgisayar', '23.599TL');
insert into urunler values('fafeb0bb-d710-4e2f-8274-3ba858e5699e', 'Klavye', '1.189TL');
insert into urunler values('177a01de-2f9a-4c60-b941-9da6dce62584', 'Fare', '650.00TL');
insert into urunler values('256346e5-5ad3-431a-8e1b-e535dfe80d26', 'Eldiven', '733.26TL');
insert into urunler values('83eada45-198f-4df8-b29b-5f0ba74678ca', 'Ayakkabı', '1.590TL');
insert into urunler values('12fbe037-85ee-4735-8723-e1d40a2ec7af', 'Kitap', '258.99TL');
insert into urunler values('5ee41757-0af8-4fe3-9136-655c40804a8e', 'Kamera', '12.800TL');
insert into urunler values('9de63242-c683-48b3-926e-6e64d5ac9d05', 'Tornavida', '499.99TL');
insert into urunler values('3ddfe885-921a-4a75-8815-ae8b5f809832', 'Hoparlör', '376.00TL');
insert into urunler values('3f2fa8b6-a90b-42aa-ba28-3d8251e6d1d3', 'Mutfak Robotu', '1.799TL');
insert into urunler values('70737983-37d3-4993-8e59-d480de92b7b7', 'Drone', '11.499TL');
insert into urunler values('a9492c52-c227-415d-a0c2-95550589d8f3', 'Kulaklık', '27.949TL');
insert into urunler values('9d0002c7-fada-478c-83d7-f4c50202c8cc', 'Raket', '259.00TL');
insert into urunler values('6d5670a5-bc46-45d6-9571-32efe1ff5ba4', 'Saat', '369.00TL');
insert into urunler values('458d945f-680c-447b-b159-9188e19abda1', 'Telefon', '66.966TL');

create table sepet(
	id varchar(64) primary key,
	kullanici_id varchar(64),
	urun_id varchar(64),
	adet int,
	foreign key (kullanici_id) references kullanicilar(id),
	foreign key (urun_id) references urunler(id)
);
