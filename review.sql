
INSERT INTO dbo.Species VALUES('Dog','Pluto ');
INSERT INTO dbo.Species VALUES('Cat','Tom');
INSERT INTO dbo.Species VALUES('Bird','Tweety');
INSERT INTO dbo.Species VALUES('Mouse','Mickey ');
INSERT INTO dbo.Species VALUES('Rabbit','Peter');

INSERT INTO DietPlans VALUES('Pluto Dog','pedigree','Dog food', 5);
INSERT INTO DietPlans VALUES('Kitty cat','tuna','Cat food', 3);
INSERT INTO DietPlans VALUES('Birdy Bird','insects','Bird food', 2);
INSERT INTO DietPlans VALUES('Mickey Mouse','cheese','mice food', 4);
INSERT INTO DietPlans VALUES('Bunny Rabbit','carrot','Rabbit food', 4);

INSERT INTO dbo.Animals VALUES(1,'Pluto', 'Dog', 50, 8, 'Pluto Dog', 'Loyal', 1, 1, 'male', 'Unadopted', NULL);
INSERT INTO dbo.Animals VALUES(2,'Tom',   'Cat', 10, 5, 'Kitty cat', 'Friendly', 1, 0, 'Male', 'Unadopted', NULL);
INSERT INTO dbo.Animals VALUES(3,'Tweety', 'Bird', 6, 5,'Birdy Bird' , 'Sweet', 0, 0, 'Female', 'Unadopted', NULL);
INSERT INTO dbo.Animals VALUES(4,'Mickey','Mouse', 5, 5, 'Mickey Mouse', 'Helpful', 0, 1, 'Male', 'Unadopted', NULL);
INSERT INTO dbo.Animals VALUES(5,'Peter', 'Rabbit', 20, 4, 'Bunny Rabbits', 'Clever', 1, 1, 'Male', 'Unadopted', NULL);



INSERT INTO dbo.Rooms VALUES(001, 101, 'Pluto');
INSERT INTO dbo.Rooms VALUES(002, 102, 'Tom');
INSERT INTO dbo.Rooms VALUES(003, 103, 'Tweety');
INSERT INTO dbo.Rooms VALUES(004, 104, 'Mickey');
INSERT INTO dbo.Rooms VALUES(005, 105, 'Peter');



INSERT INTO Shots VALUES('Rabies');
INSERT INTO Shots VALUES('Tetanus');
INSERT INTO Shots VALUES('Bird Flu');
INSERT INTO Shots VALUES('Candidiasis');
INSERT INTO Shots VALUES('Myxomatosis');
