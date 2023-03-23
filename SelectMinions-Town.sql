SELECT minions.Name,towns.Name 
FROM minions
INNER JOIN towns
ON towns.id=minions.town_id
WHERE minions.id=2