create table CoursesGroups
(
    ID integer NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    Name varchar(255) NOT NULL
);

INSERT INTO CoursesGroups (Name) VALUES ('Программирование')
,('Архитектура')
,('Инфраструктура')
,('Безопасность')
,('Data Science')
,('GameDev')
,('Управление')
,('Аналитика')
,('Тестирование');


create table CoursesLevel
(
    ID integer NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    Name varchar(255) NOT NULL
);

INSERT INTO CoursesLevel (Name) VALUES ('Basic')
,('Professional')
,('Advanced');


create table Courses
(
    ID integer NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    Name varchar(255) NOT NULL,
    CourseGroupID integer REFERENCES CoursesGroups (ID),
    CourseLevelID  integer REFERENCES CoursesLevel (ID),
    CourseDuration integer
);

INSERT INTO Courses (Name, CourseGroupID, CourseLevelID, CourseDuration) VALUES ('Java Developer. Basic', 1, 1, 4)
,('HTML/CSS', 1, 1, 3)
,('Unreal Engine Game Developer. Professional', 6, 2, 5)
,('Unity Game Developer. Professional', 6, 2, 5)
,('Apache Kafka', 5, 3, 4)
,('Spark Developer', 5, 3, 4);
