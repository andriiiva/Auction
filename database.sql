DROP DATABASE IF EXISTS AuctionDB;
CREATE DATABASE AuctionDB;
USE AuctionDB;

CREATE TABLE Auctions (
    ID INT NOT NULL AUTO_INCREMENT,
    Name varchar(255) NOT NULL,
    Status ENUM('NOTSTARTED', 'STARTED', 'CLOSED') NOT NULL DEFAULT 'NOTSTARTED',
    PRIMARY KEY (ID)
); 

CREATE TABLE Users (
    ID INT NOT NULL AUTO_INCREMENT,
    Name varchar(255) NOT NULL,
    PRIMARY KEY (ID)
); 

CREATE TABLE Lots (
    ID INT NOT NULL AUTO_INCREMENT,
    Name varchar(255) NOT NULL,
    UserID INT NOT NULL,
    AuctionID INT NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (AuctionID) REFERENCES Auctions (ID),
    FOREIGN KEY (UserID) REFERENCES Users (ID)
); 

CREATE TABLE Bids (
    ID INT NOT NULL AUTO_INCREMENT,
    UserID INT NOT NULL,
    LotID INT NOT NULL,
    Price INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users (ID),
    PRIMARY KEY (ID)
); 

CREATE TABLE BiddersAuctions (
    AuctionID INT NOT NULL,
    UserID INT NOT NULL,
    FOREIGN KEY (AuctionID) REFERENCES Auctions (ID),
    FOREIGN KEY (UserID) REFERENCES Users (ID)
); 

INSERT INTO Users(Name) VALUES ('Ivanes Kurdupl');
INSERT INTO Users(Name) VALUES ('Claudia Trofimovna');
INSERT INTO Users(Name) VALUES ('Pied Dudochnik');
INSERT INTO Users(Name) VALUES ('Akaki Kalambur');

INSERT INTO Auctions(Name) VALUES ('Lydia Cakes');

INSERT INTO Lots(Name, UserID, AuctionID) VALUES ('Golden patty with cabbage', 2, 1);
INSERT INTO Lots(Name, UserID, AuctionID) VALUES ('Extract potions', 2, 1);
INSERT INTO Lots(Name, UserID, AuctionID) VALUES ('Iron Cucumber', 2, 1);

INSERT INTO BiddersAuctions(AuctionID, UserID) VALUES (1, 1);
INSERT INTO BiddersAuctions(AuctionID, UserID) VALUES (1, 3);
INSERT INTO BiddersAuctions(AuctionID, UserID) VALUES (1, 4);

UPDATE Auctions SET Status='STARTED' WHERE ID=2;

INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 4, 500);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 1, 666);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 3, 667);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 1, 668);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 4, 672);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 3, 700);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 4, 800);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 3, 900);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 4, 6666);
INSERT INTO Bids(LotID, UserID, Price) VALUES (1, 3, 9999999);

UPDATE Auctions SET Status='CLOSED' WHERE ID=2;

SELECT LotID, Price FROM Bids WHERE UserID = 3;
SELECT Name FROM Users;

SELECT Name, LotID, Price FROM Users JOIN Bids ON Users.ID = Bids.UserID WHERE UserID = 3;
