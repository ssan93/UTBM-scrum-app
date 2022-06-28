-- Table users
INSERT INTO users (id, firstname, lastname, email, password) VALUE(1, 'Elena', 'Hessel', 'elena@lueilwitz.biz', 'o8ZEeg8YurJWs/zykodMwA==');
INSERT INTO users (id, firstname, lastname, email, password) VALUE(2, 'Johnathan', 'Kuhic', 'johnathan@ferrytremblay.com', 'o8ZEeg8YurJWs/zykodMwA==');
INSERT INTO users (id, firstname, lastname, email, password) VALUE(3, 'Dannie', 'Spinka', 'dannie@damore.us', 'o8ZEeg8YurJWs/zykodMwA==');

-- Table project
INSERT INTO project (id, name, description, archived) VALUE(1, 'Inscription', 'Deleniti quos suscipit voluptatibus et quia nulla amet.', False);
INSERT INTO project (id, name, description, archived) VALUE(2, 'Inscription', 'Molestiae voluptates nostrum omnis nesciunt id.', False);
INSERT INTO project (id, name, description, archived) VALUE(3, 'RSA', 'Qui sint et voluptatem iure repellendus ducimus recusandae.', True);
INSERT INTO project (id, name, description, archived) VALUE(4, 'RSA', 'Delectus soluta vero consectetur aliquam.', False);
INSERT INTO project (id, name, description, archived) VALUE(5, 'AES', 'Atque qui soluta aut ut tenetur.', False);
INSERT INTO project (id, name, description, archived) VALUE(6, 'AES', 'Aut et distinctio animi ea esse deleniti sunt nisi.', True);
INSERT INTO project (id, name, description, archived) VALUE(7, 'Scrum', 'Molestias occaecati sint impedit.', False);
INSERT INTO project (id, name, description, archived) VALUE(8, 'Voyages', 'Possimus pariatur officia iste recusandae ut voluptas quis.', False);
INSERT INTO project (id, name, description, archived) VALUE(9, 'IHM', 'Nemo repellat ea doloribus aut ut quia molestiae sed.', True);
INSERT INTO project (id, name, description, archived) VALUE(10, 'Inscription', 'Est laborum quisquam autem.', False);

-- Table member
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(1, 'SM', 1, 1, True);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(2, 'PO', 1, 2, True);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(3, 'DEV', 1, 3, False);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(4, 'DEV', 1, 4, False);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(5, 'DEV', 1, 5, False);

INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(6, 'DEV', 2, 1, True);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(7, 'SM', 2, 2, True);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(8, 'DEV', 2, 3, False);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(9, 'DEV', 2, 4, False);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(10, 'DEV', 2, 5, False);

INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(11, 'PO', 3, 1, True);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(12, 'SM', 3, 2, True);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(13,'DEV', 3, 3, False);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(14, 'DEV', 3, 4, False);
INSERT INTO member (id, role, user_id, project_id, pinned) VALUE(15, 'DEV', 3, 5, False);

-- Table sprint
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(1, 'Sprint n°1', '1999/7/26', '2000/10/20', 1);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(2, 'Sprint n°2', '2001/5/25', '2003/8/11', 1);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(3,'Sprint n°3', '2020/7/28', '2020/10/28', 1);

INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(4, 'Sprint n°1', '1999/7/26', '2000/10/20', 2);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(5, 'Sprint n°2', '2001/5/25', '2003/8/11', 2);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(6,'Sprint n°3', '2020/7/28', '2020/10/28', 2);

INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(7, 'Sprint n°1', '1999/7/26', '2000/10/20', 3);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(8, 'Sprint n°2', '2001/5/25', '2003/8/11', 3);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(9,'Sprint n°3', '2020/7/28', '2020/10/28', 3);

INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(10, 'Sprint n°1', '1999/7/26', '2000/10/20', 4);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(11, 'Sprint n°2', '2001/5/25', '2003/8/11', 4);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(12,'Sprint n°3', '2020/7/28', '2020/10/28', 4);

INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(13, 'Sprint n°1', '1999/7/26', '2000/10/20', 5);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(14, 'Sprint n°2', '2001/5/25', '2003/8/11', 5);
INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE(15,'Sprint n°3', '2020/7/28', '2020/10/28', 5);

-- Table userstory
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(1, 'Footer', 'Sit eos qui debitis.', 10, 2, 'REVIEW' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(2, 'Navigation', 'Aut porro consequatur similique', 10, 2, 'DONE' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(3, 'Connexion', 'Repellat labore odit et dolore.', 10, 2, 'PROGRESS' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(4, 'Adminisatration', 'Aut porro consequatur similique.', 10, 2, 'DONE' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(5, 'Footer', 'Sit eos qui debitis.', 10, 2, 'REVIEW' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(6, 'Profile', 'Repellat labore odit et dolore.', 10, 2, 'PROGRESS' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(7, 'Parmètres', 'Repellat labore odit et dolore.', 10, 2, 'PROGRESS' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(8, 'Fixtures', 'Sit eos qui debitis.', 10, 2, 'REVIEW' , 1, 1);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(9, 'Navigation', 'Aut porro consequatur similique nemo', 10, 2, 'DONE' , 1, 1);


INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(10, 'Inscription', 'Omnis illum blanditiis iure.', 3, 3, 'DONE' , 4, 2);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(11,  'Paramètres', 'Est omnis dolor est.', 10, 3, 'TODO' , 5, 2);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(12, 'Navigation', 'Id facere sunt expedita.', 1, 1, 'REVIEW' , 6, 2);

INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(13, 'Administration', 'Quia aut qui fuga ut adipisci qui debitis officia facilis.', 9, 3, 'PROGRESS' , 7, 3);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(14, 'Connexion', 'Quia quo et fugiat facilis quaerat et quam minima.', 4, 2, 'DONE' , 8, 3);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(15, 'Fixtures', 'Iusto asperiores qui laborum sed quia pariatur qui.', 8, 3, 'REVIEW' , 9, 3);

INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(16, 'Footer', 'Illum quia voluptas officia quis quisquam.', 8, 3, 'PROGRESS' , 10, 4);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(17, 'Connexion', 'Et voluptas et aperiam.', 8, 1, 'DONE' , 11, 4);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(18, 'Parmètres', 'Doloremque exercitationem quia dicta atque et enim quae aut.', 8, 3, 'PROGRESS' , 12, 4);

INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(19, 'Navigation', 'Qui repudiandae dolorem dolores.', 8, 3, 'REVIEW' , 13, 5);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(20, 'Administration', 'Modi sequi qui quos beatae provident blanditiis deleniti.', 4, 2, 'PROGRESS' , 14, 5);
INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE(21, 'Parmètres', 'Occaecati soluta accusantium qui rem.', 1, 1, 'PROGRESS' , 15, 5);


-- Table userstorycomment
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(1, 'Rem beatae aspernatur est tempore.', '2010/3/19', 1, 1);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(2, 'Eos assumenda mollitia et et ad tempora sunt.', '2010/9/12', 2, 1);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(3, 'Qui ut rerum impedit.', '2017/2/26', 3, 1);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(4, 'Eum et ratione et inventore et vel.', '2000/1/12', 4, 2);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(5, 'Laborum non voluptatem autem maiores adipisci vero omnis.', '2009/10/31', 5, 2);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(6, 'Quibusdam rerum est et exercitationem nisi.', '2019/7/14', 6, 2);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(7, 'Soluta ad quaerat quia exercitationem molestiae quis minima.', '1999/11/16', 7, 3);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(8, 'Culpa commodi similique aperiam fuga id voluptas.', '2003/2/09', 8, 3);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(9, 'Facilis est ut eius delectus earum est.', '2014/4/21', 9, 3);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(10, 'Est molestiae quod eaque nihil nihil labore voluptates non.', '2002/1/18', 10, 4);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(11, 'Perspiciatis voluptate et eaque autem velit maxime fugit dolores nulla.', '2015/1/29', 11, 4);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(12, 'Minima maiores non ea sed quia quae.', '2019/11/09', 12, 4);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(13, 'Dolores voluptate vero nostrum iste harum ullam eveniet.', '2002/8/20', 13, 5);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(14, 'Est cumque quia consequuntur eaque est reiciendis eum excepturi esse.', '2006/1/27', 14, 5);
INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE(15, 'Enim ratione enim doloribus ut quo cum ea rerum.', '2013/8/22', 15, 5);

-- Table userstorymember
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(1, 1, 1);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(2, 2, 1);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(3, 3, 1);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(4, 4, 1);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(5, 4, 1);

INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(6, 1, 2);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(7, 2, 2);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(8, 3, 2);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(9, 4, 2);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(10, 4, 2);

INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(11, 1, 3);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(12, 2, 3);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(13, 3, 3);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(14, 4, 3);
INSERT INTO userstorymember (id, member_id, userstory_id) VALUE(15, 4, 3);

