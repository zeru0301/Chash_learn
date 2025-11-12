

-- 商品カテゴリーの作成
CREATE TABLE category (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(255) UNIQUE
);
-- 入力値　商品カテゴリー
    insert into category (category_id,  category_name) values (1,"ノンシュガー");
    insert into category (category_id,  category_name) values (2,"ノンシュガー");

-- 商品テーブルの作成
create table product(
    product_id int primary key,
    product_name varchar(255) unique,
    product_description varchar(255),
    product_price int,
    product_images varchar(255),
    category_id int
);

-- 購入履歴
CREATE TABLE purchase_history (
    id INT PRIMARY KEY AUTO_INCREMENT,
    product_name VARCHAR(255),
    product_pieces INT,
    history_timestamp TIMESTAMP
);

--入力DB
create table inquiry_history(
    id int  AUTO_INCREMENT PRIMARY KEY,
    inquiry_name VARCHAR(255),
    inquiry_form VARCHAR(400),
    history_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP

);

-- 入力値 商品テーブル

INSERT INTO product(product_id,product_name,product_description,product_price,product_images,category_id)
values(1,"ブラックK","自社製品のすべての味のベースとなった初作品、活力がみなぎります！",4000,"imgs/img1.png",1);
INSERT INTO product(product_id,product_name,product_description,product_price,product_images,category_id)
values(2,"ブラックKノンシュガー","ブラックKのノンシュガー商品!",4000,"imgs/img1.png",2);
INSERT INTO product(product_id,product_name,product_description,product_price,product_images,category_id)
values(3,"ブルーレッドK","夏の強い日差しとブルーハワイの味がする夏を感じさせる一品!",4000,"imgs/img2.png",1);
INSERT INTO product(product_id,product_name,product_description,product_price,product_images,category_id)
values(4,"グレープK","グレープの甘さが引き立つ約束されたおいしさ!",4000,"imgs/img3.png",1);
INSERT INTO product(product_id,product_name,product_description,product_price,product_images,category_id)
values(5,"スノーホワイトK","ノンシュガーで雪のような透明な後味!",4000,"imgs/img4.png",2);