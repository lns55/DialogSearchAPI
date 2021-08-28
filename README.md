# DialogSearchAPI
Task Description
Есть сущность RGDialogsClients. Она предназначена для хранения информации о том, какие пользователи взаимодействуют в рамках одного диалога. Т.е. может быть N-ое количество IDClient, объединенных одним диалогом. Функция Init позоволяет получить набор сущностей, с котороыми можно производить операции.

Задача

Написать проект WebAPI в котором будет реализован метод API поиска диалога с теми идентификаторами клиентов, которые были переданы в метод. Метод должен принимать список идентфикаторов клиентов для которых необходимо найти диалог. Нужно найти такой диалог, в котором есть все переданные клиенты. Если такого диалога нет, то возвращается пустой GUID. Если диалог найден возвращается идентификатор диалога. Метод должен быть описан в соотвествии со стандартом OpenAPI и доступен через SwaggerUI
