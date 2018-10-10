SELECT * FROM dbo.t_student;

INSERT INTO dbo.t_student
(
    Id,
    username,
    loginname,
    password,
    sex,
    birthday
)
VALUES
(   2,        -- Id - int
    'ffff',       -- username - varchar(100)
    'ssss',       -- loginname - varchar(50)
    '',       -- password - varchar(100)
    '',       -- sex - char(1)
    GETDATE() -- birthday - datetime
    )
	SELECT inserted