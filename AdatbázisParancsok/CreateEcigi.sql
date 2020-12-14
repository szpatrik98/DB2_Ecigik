drop table ecigik;
create table autok
(
    sorszam char(6) not null,
    nev char(15) not null,
    szin char(17) not null,
    gyarto_id int not null, 
    watt int not null,
    megjelenesev date not null,
    tipus char(5) not null,
    
    constraint pk_ecigik primary key(sorszam),
    constraint ch_ecigik_tipus check(tipus in ('RTA', 'DRTA', 'DDRT')),
    constraint fk_gyartok foreign key(gyarto_id)
        references gyartok(id)
);