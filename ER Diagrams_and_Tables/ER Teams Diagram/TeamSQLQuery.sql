create database TeamDatabase;
use TeamDatabase;

create table Player
(
PlayerID int not null, 
Name varchar(20) not null,
Age int,
Avatar varchar(2) not null,
);

alter table Player
ADD PRIMARY KEY (PlayerID)

select * from Player;

create table Team
(
TeamID int IDENTITY(1,1) PRIMARY KEY,
Brand varchar(20) not null,
NumberofPlayers int,
PlayerID int FOREIGN KEY REFERENCES Player (PlayerID)
);

create table Match
(
MatchID int IDENTITY(1,1) PRIMARY KEY, 
Venue varchar(20) not null,
);

create table Team_Match
(
Outcome varchar(4),
MatchID int FOREIGN KEY REFERENCES Match(MatchID),
TeamID int FOREIGN KEY REFERENCES Team(TeamID)
);

select * from Team_Match;