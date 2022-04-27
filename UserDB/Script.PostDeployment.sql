IF NOT EXISTS (SELECT 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Julius', 'Vaigauskas'),
	('Sue', 'Storm'),
	('Tim', 'Corey'),
	('John', 'Mickey');
end

