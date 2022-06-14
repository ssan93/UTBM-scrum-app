create database scrum;

CREATE TABLE `users` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `lastname` varchar(255),
  `firstname` varchar(255),
  `email` varchar(255),
  `password` varchar(255)
);

CREATE TABLE `Member` (
  `id` int PRIMARY KEY,
  `role` varchar(255),
  `user_id` int
);

CREATE TABLE `Project` (
  `id` int PRIMARY KEY,
  `name` varchar(255),
  `archived` boolean,
  `created_dt` date
);

CREATE TABLE `Sprint` (
  `id` int PRIMARY KEY,
  `name` varchar(255),
  `startDate` date,
  `endDate` date,
  `Project_id` int
);

CREATE TABLE `UserStory` (
  `id` int PRIMARY KEY,
  `name` varchar(255),
  `description` varchar(255),
  `complexity` int,
  `priority` int,
  `state` boolean,
  `Project_id` int
);

CREATE TABLE `UserStoryComment` (
  `id` int PRIMARY KEY,
  `description` varchar(255),
  `date` datetime,
  `memberId` int,
  `userstory_id` int
);

CREATE TABLE `UserStoryMember` (
  `id` int,
  `member_id` int,
  `user_id` int
);

ALTER TABLE `users` ADD FOREIGN KEY (`id`) REFERENCES `Member` (`user_id`);

ALTER TABLE `Member` ADD FOREIGN KEY (`user_id`) REFERENCES `Project` (`id`);

ALTER TABLE `Sprint` ADD FOREIGN KEY (`Project_id`) REFERENCES `Project` (`id`);

ALTER TABLE `UserStory` ADD FOREIGN KEY (`Project_id`) REFERENCES `Project` (`id`);

ALTER TABLE `UserStoryComment` ADD FOREIGN KEY (`userstory_id`) REFERENCES `UserStory` (`id`);

ALTER TABLE `UserStoryComment` ADD FOREIGN KEY (`memberId`) REFERENCES `Member` (`id`);
