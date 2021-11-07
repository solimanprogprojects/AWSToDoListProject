use todolistdatabase;

CREATE TABLE IF NOT EXISTS `todolistdatabase`.`User` (
  `userId` INT NOT NULL AUTO_INCREMENT,
  `firstName` VARCHAR(20) NOT NULL,
  `lastName` VARCHAR(20) NOT NULL,
  `userName` VARCHAR(8) NOT NULL,
  `password` VARCHAR(8) NOT NULL,
  `userLoggedIn` BOOL NOT NULL,
  `userLoggedOut` BOOL NOT NULL,
  `lastLogin` DATETIME,
  `lastLogout` DATETIME,
  PRIMARY KEY (`userId`),
  UNIQUE INDEX `userId_UNIQUE` (`userId` ASC) VISIBLE );
  
INSERT INTO user (userID, firstName, lastName, userName, password, userLoggedIn, userLoggedOut, lastLogin, lastLogout)
VALUES (1, 'Soliman', 'Soliman', 'soli1234', 'pass1234', false, false, null, null);

CREATE TABLE IF NOT EXISTS `todolistdatabase`.`ToDoList` (
  `toDoListId` INT NOT NULL AUTO_INCREMENT,
  `userId` INT NOT NULL,
  `listName` VARCHAR(20) NOT NULL,
  `listDescription` VARCHAR(100) NOT NULL,
  `listComplete` BOOL NOT NULL,
  PRIMARY KEY (`toDoListId`),
  UNIQUE INDEX `toDoListId_UNIQUE` (`toDoListId` ASC) VISIBLE );
  
  CREATE TABLE IF NOT EXISTS `todolistdatabase`.`ToDoListItem` (
  `toDoListItemId` INT NOT NULL AUTO_INCREMENT,
  `toDoListId` INT NOT NULL,
  `itemName` VARCHAR(20) NOT NULL,
  `itemDescription` VARCHAR(100) NOT NULL,
  `itemDoneDateTime` DATETIME,
  `itemDone` BOOL NOT NULL,
  PRIMARY KEY (`toDoListItemId`),
  UNIQUE INDEX `toDoListItemId_UNIQUE` (`toDoListItemId` ASC) VISIBLE );