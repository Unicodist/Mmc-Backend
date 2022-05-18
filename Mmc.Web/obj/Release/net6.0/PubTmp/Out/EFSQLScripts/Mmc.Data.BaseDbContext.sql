CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    ALTER DATABASE CHARACTER SET utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    CREATE TABLE `User_Master` (
        `UserMasterId` bigint NOT NULL AUTO_INCREMENT,
        `UserMasterName` longtext CHARACTER SET utf8mb4 NOT NULL,
        `UserType` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Email` longtext CHARACTER SET utf8mb4 NOT NULL,
        `Password` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_User_Master` PRIMARY KEY (`UserMasterId`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    CREATE TABLE `blog_master` (
        `BlogMasterId` int NOT NULL AUTO_INCREMENT,
        `BlogMasterTitle` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
        `BlogMasterAuthorAdminId` bigint NOT NULL,
        `BlogMasterBody` longtext CHARACTER SET utf8mb4 NOT NULL,
        `BlogMasterPostedDate` datetime(6) NOT NULL DEFAULT '2022-03-22 09:07:07.415611',
        `BlogMasterAuthorName` longtext CHARACTER SET utf8mb4 NOT NULL,
        CONSTRAINT `PK_blog_master` PRIMARY KEY (`BlogMasterId`),
        CONSTRAINT `FK_blog_master_User_Master_BlogMasterAuthorAdminId` FOREIGN KEY (`BlogMasterAuthorAdminId`) REFERENCES `User_Master` (`UserMasterId`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    CREATE TABLE `notice_master` (
        `NoticeMasterId` bigint NOT NULL AUTO_INCREMENT,
        `NoticeMasterTitle` longtext CHARACTER SET utf8mb4 NOT NULL,
        `NoticeMasterBody` longtext CHARACTER SET utf8mb4 NOT NULL,
        `PostedOn` datetime(6) NOT NULL DEFAULT '2022-03-22 09:07:07.416159',
        `NoticeMasterNoticePicture` longtext CHARACTER SET utf8mb4 NULL,
        `NoticeMasterAuthorId` bigint NOT NULL,
        CONSTRAINT `PK_notice_master` PRIMARY KEY (`NoticeMasterId`),
        CONSTRAINT `FK_notice_master_User_Master_NoticeMasterAuthorId` FOREIGN KEY (`NoticeMasterAuthorId`) REFERENCES `User_Master` (`UserMasterId`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    CREATE INDEX `IX_blog_master_BlogMasterAuthorAdminId` ON `blog_master` (`BlogMasterAuthorAdminId`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    CREATE INDEX `IX_notice_master_NoticeMasterAuthorId` ON `notice_master` (`NoticeMasterAuthorId`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220322032207_Initial') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20220322032207_Initial', '6.0.3');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220326173013_IterationI') THEN

    ALTER TABLE `notice_master` MODIFY COLUMN `PostedOn` datetime(6) NOT NULL DEFAULT '2022-03-26 23:15:13.044433';

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220326173013_IterationI') THEN

    ALTER TABLE `blog_master` MODIFY COLUMN `BlogMasterPostedDate` datetime(6) NOT NULL DEFAULT '2022-03-26 23:15:13.044086';

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20220326173013_IterationI') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20220326173013_IterationI', '6.0.3');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

