---
layout: single
title:  "22번째 포스팅입니다!"
---
# Heidisql (회원가입과 상품등록)

-- 회원가입 INSERT
insert into member
(reg_time, update_time, created_by, modified_by, 
 address, email, name, password, role)
values
(now(),now(),'','','대구','k9315861@naver.com','김상의','password','admin');

-- 상품 등록을 위한 INSERT
insert 
into
    item
    (created_by, item_detail, item_nm, item_sell_status, 
    modified_by, price, reg_time, stock_number, update_time, item_id) 
values
    ('만드는사람','귤 맛있어요','귤 한 박스','판매중',
    '수정하는사람',25000, now(), 10, now(), 3);
