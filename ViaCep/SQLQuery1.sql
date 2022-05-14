CREATE TABLE TbAddress (
	AddressId uniqueidentifier not null,
    Cep varchar(15),
    District varchar(100),
    Complement varchar(100),
    Ddd varchar(3),
    Gia varchar(100),
	Uf varchar(5),
	Ibge varchar(10),
	Locality varchar(100),
	PublicPlace varchar(100),
	Siafi varchar(100),
	Date datetime,
	primary key (AddressId)
);
