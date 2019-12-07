create table permissions(
    id int identity primary key,
    name varchar(200) not null
);
create table roles(
    id int identity primary key,
    name varchar(200) not null
);
create table roles_permissions(
    permissions_id int references roles(id),
    roles_id int references permissions(id)
);
create table player(
    id int identity primary key,
    login varchar(100),
    password varchar(100),
);
create table attributes(
    id int identity primary key,
    strength int,
    inteligence int,
    dexterity int,
    wisdom int,
    charisma int,
    constitution int
);
create table section(
    id int identity primary key,
    history varchar(5000),
    name varchar(200),
    password varchar(200)
);
create table section_player(
  player_id int references player(id),
  section_id int references section(id)
);
create table spells(
   id int identity primary key,
   name varchar(45),
   damage float,
   cost float,
   cooldown time(0),
   prefix varchar (50)
);
create table characters(
    id int identity primary key,
    name varchar(200),
    sex varchar(1),
    life float,
    history varchar(5000),
    xp float,
    ac int,
    mana float,
    spell_id int references spells(id),
    section_id int references section(id),
    attributes_id int references attributes(id),
    player_id int references player(id),
    inventory_id int references inventory(id)
);
create table creatures(
    id int identity primary key,
    name varchar(200),
    life float,
    lvl float,
    mana float,
    weight float,
    height float,
    xp float,
    inventory_id int references inventory(id),
    attributes_id int references attributes(id),
    spell_id int references spells(id),
    section_id int references section(id)
);
create table section_creatures(
    section_id int references section(id),
    creatures_id int references creatures(id)
);
create table conditions(
    id int identity primary key,
    name varchar(45),
    value float,
    description varchar(500)
);
create table conditions_creatures(
    conditions_id int references conditions(id),
    creatures_id int references creatures(id)
);
create table conditions_character(
    conditions_id int references conditions(id),
    character_id int references characters(id)
);
create table inventory(
    id int identity primary key,
    size int
);
create table object(
    id int identity primary key,
    name varchar(45),
    durability varchar(45),
    weight float,
    height float,
    price decimal(6,2),
    inventory_id int references inventory(id)
);
create table inventory_character(
    inventory_id int references inventory(id),
    character_id int references inventory(id)
);
create table inventory_creature(
     inventory_id int references inventory(id),
     creature_id int references inventory(id)
);
create table armor(
    id int identity primary key,
    name varchar(45),
    defense varchar(45),
    weight varchar(45),
    object_id int references object(id)
);
create table conditions_armor(
    conditions_id int references conditions(id),
    armor_id int references armor(id)
);
create table weapons(
    id int identity primary key,
    name varchar(45),
    damage varchar(45),
    weight varchar(45),
    object_id int references object(id)
);
create table conditions_weapons(
    conditions_id int references weapons(id),
    weapons_id int references weapons(id)
);
create table potions(
    id int identity primary key,
    name varchar(45),
    object_id int references object(id)
);
create table conditions_potions(
    conditions_id int references conditions(id),
    potions_id int references potions(id)
);

create table player_spells(
   player_id int references player(id),
   spell_id int references spells(id)
);
create table spells_conditions(
   spell_id int references spells(id),
   conditions_id int references conditions(id) 
);
