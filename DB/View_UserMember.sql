create view view_UserMember
as
select u.user_name,u.password,u.email,u.contact_number,r.role_name from tbl_Users as u
inner join tbl_Members as m
on m.user_id = u.u_id join tbl_Roles as r on u.role_id = r.r_id;