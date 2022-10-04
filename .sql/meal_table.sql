CREATE TABLE meals (
	id serial PRIMARY KEY,
	name VARCHAR ( 50 ) UNIQUE NOT NULL,
	prep_time TIME,
	cook_time TIME,
	vegan boolean NOT NULL,
	vegetarian NOT NULL,
	servings int,
	ingridients text[] NOT NULL,
);