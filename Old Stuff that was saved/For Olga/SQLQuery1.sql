/*select * from Ingredient*/

Select * from recipe

select a.Name from Ingredient a
inner join RecipeIngredient b on a.id = IngredientId
where b.Recipeid = 2;

update Recipe
set Name = 'Salad'
Where id = 2;

/*delete from Recipe
where id = 7;*/

/*insert into Recipe
values ('salad ultima', 50, 'combine evrything');*/