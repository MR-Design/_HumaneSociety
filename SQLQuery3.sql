INSERT INTO Species VALUES('Dog');
INSERT INTO Species VALUES('Cat');
INSERT INTO Species VALUES('Bird');
INSERT INTO Species VALUES('Mouse');
INSERT INTO Species VALUES('Rabbit');

INSERT INTO DietPlans VALUES('Pluto Dog','Dog food', 14);
INSERT INTO DietPlans VALUES('Kitty cat','Cat food', 7);
INSERT INTO DietPlans VALUES('Birdy Bird','Bird food', 4);
INSERT INTO DietPlans VALUES('Mickey Mouse','mice food', 7);
INSERT INTO DietPlans VALUES('Bunny Rabbits','Rabbit food', 4);

INSERT INTO Animals VALUES('Pluto', 1, 50, 8, 'Pluto Dog', 'Loyal', 1, 1, 'male', 'Unadopted', NULL);
INSERT INTO Animals VALUES('Tom',   2, 10, 5, 'Kitty cat', 'Friendly', 1, 0, 'Male', 'Unadopted', NULL);
INSERT INTO Animals VALUES('Tweety' 3, 2, 6,'Birdy Bird' , 'Sweet', 0, 0, 'Female', 'Unadopted', NULL);
INSERT INTO Animals VALUES('Mickey',4, 5, 5, 'Mickey Mouse', 'Helpful', 0, 1, 'Male', 'Unadopted', NULL);
INSERT INTO Animals VALUES('Peter', 5, 20, 4, 'Bunny Rabbits', 'Clever', 1, 1, 'Male', 'Unadopted', NULL);

ALTER TABLE Rooms ADD RoomNumber INTEGER;
ALTER TABLE Rooms ADD AnimalName VARCHAR(50);

INSERT INTO Rooms VALUES(1, 101, 'Pluto');
INSERT INTO Rooms VALUES(2, 102, 'Tom');
INSERT INTO Rooms VALUES(3, 103, 'Tweety');
INSERT INTO Rooms VALUES(4, 104, 'Mickey');
INSERT INTO Rooms VALUES(5, 105, 'Peter');



INSERT INTO Shots VALUES('Rabies');
INSERT INTO Shots VALUES('Tetanus');
INSERT INTO Shots VALUES('Bird Flu');
INSERT INTO Shots VALUES('Candidiasis');
INSERT INTO Shots VALUES('Myxomatosis');
