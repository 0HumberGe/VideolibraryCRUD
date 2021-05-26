# PIA Backend

## Integrantes del equipo:

Ricardo López Novelo

Humberto Gerardo Peña Páez

Miguel Alejandro Rodríguez Rocha

# Manual técnico

## Esquema
<img src="./img/esquema.jpeg">

## Endpoint GET

Método GET

GET/api/Movie

Sin parametros

Request body:

No aplica

<img src="./img/get.jpeg">

## Endpoint POST

Método POST

POST/api/Movie

Sin parametros

Request body:

{
  "title": "string",
  "director": "string",
  "genre": "string",
  "releaseYear": 0,
  "rating": "string"
}

<img src="./img/post.jpeg">

## Endpoint PUT
Método PUT

PUT/api/Movie/{id}

Parametros: id (integer)

Request body:

{
  "title": "string",
  "director": "string",
  "genre": "string",
  "releaseYear": 0,
  "rating": "string"
}

<img src="./img/put.jpeg">

## Endpoint DELETE
Método DELETE

DELETE/api/Movie/{id}

Parametros: id (integer)

Request body:

No aplica

<img src="./img/delete.jpeg">
