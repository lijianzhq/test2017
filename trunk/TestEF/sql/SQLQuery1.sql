--SELECT * FROM dbo.t_student;


--EXEC sp_addextendedproperty 't_student', '用户名','user','dbo','table','t_student','column','username';
EXEC sp_addextendedproperty 't_student','aaaaa','user','dbo','table','t_student',NULL,NULL;
EXEC sp_updateextendedproperty 't_student','ddddd','user','dbo','table','t_student','column','username';


SELECT [value] 
FROM fn_listextendedproperty (
NULL, 
'schema', 'dbo', 
'table', 't_student', 
NULL, NULL)

SELECT 
A.name AS tablename,
B.name AS columnname,
C.value  AS columndescription
FROM sys.tables A
INNER JOIN sys.columns B ON A.object_id =  B.object_id
LEFT JOIN sys.extended_properties C ON C.major_id = B.object_id AND C.minor_id = B.column_id
WHERE A.name = 't_student';

SELECT * FROM sys.tables a WHERE a.object_id = '565577053'; 
SELECT * FROM sys.columns;
SELECT * FROM sys.extended_properties;