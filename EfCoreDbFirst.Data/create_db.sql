-- Создание таблицы Authors (Авторы)
CREATE TABLE table_authors
(
    id         INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    first_name TEXT NOT NULL,
    last_name  TEXT NOT NULL
);

-- Создание таблицы Books (Книги) с внешним ключом на Authors
CREATE TABLE table_books
(
    id                  INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    title               TEXT NOT NULL,
    year_of_publication INT,
    author_id           INT  NOT NULL,
    FOREIGN KEY (author_id) REFERENCES table_authors (id) ON DELETE SET NULL
);

-- Заполнение таблицы Authors тестовыми данными
INSERT INTO table_authors (first_name, last_name)
VALUES ('Лев', 'Толстой'),
       ('Фёдор', 'Достоевский'),
       ('Антон', 'Чехов'),
       ('Михаил', 'Булгаков'),
       ('Иван', 'Тургенев'),
       ('Николай', 'Гоголь'),
       ('Александр', 'Пушкин');

-- Заполнение таблицы Books тестовыми данными
INSERT INTO table_books (title, year_of_publication, author_id)
VALUES ('Война и мир', 1869, 1),
       ('Анна Каренина', 1877, 1),
       ('Преступление и наказание', 1866, 2),
       ('Идиот', 1869, 2),
       ('Братья Карамазовы', 1880, 2),
       ('Чайка', 1896, 3),
       ('Дядя Ваня', 1897, 3),
       ('Собачье сердце', 1925, 4),
       ('Мастер и Маргарита', 1967, 4),
       ('Отцы и дети', 1862, 5),
       ('Мёртвые души', 1842, 6),
       ('Ревизор', 1836, 6),
       ('Евгений Онегин', 1833, 7);