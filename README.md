# Ecommerce App using ASP.NET Core and React

Hi there,

I spent some time writing one full stack project using ASP.NET Core and React with other best practices as explained below. This app was made for the sole purpose of study and fun. I hope you like it.

This project was inspired by Rahul Sahay's excellent eCommerce project. Here's the [link](https://github.com/rahulsahay19/eCommerce-App) to his project.

## Project structure

The project was structured in two main folders: backend and frontend:

![Captura de tela 2022-10-21 201353](https://user-images.githubusercontent.com/62616436/197303811-70e17fc6-2030-4d35-acd6-b39e260deeba.jpg)

The backend architecture is based on the principles of Clean Architecture and DDD:

![image](https://user-images.githubusercontent.com/62616436/197306704-176f824a-eccb-4bd1-bb5d-8247e9c532d6.png)

In the frontend part, I organized the React project as follows:

![image](https://user-images.githubusercontent.com/62616436/197306979-3078cec2-441a-44f5-bda5-e2d2ea64c43a.png)

## Backend

This project is built using ASP.NET Core 5. You can cd into API directory and say **dotnet restore** and then **dotnet watch run**.

### Backend technologies

- ASP.NET Core
- MediatR
- NWebsec
- Generic Repository Patterns
- Unit of Work Pattern
- Sqlite during devlopment
- Mysql in Production
- Swagger
- Automapper
- Hosted Services
- SignalR
- EntityFramework Core
- Identity
- Redis Distributed Cache

## Frontend

This project was generated with [Vite](https://vitejs.dev/guide/) command. You can cd into frontend folder and do **npm i** to install the packages then **npm run dev** to run the project.

### Frontend technologies

- React
- Typescript
- TailwindCSS
- React Query
- Formik
- MobX
- Axios

### Mobile UX

This project is fully mobile friendly. I used classes from TailwindCSS to facilitate the construction of my custom components, as if it were a basic version of a UI Kit. So it took a lot of time writing CSS which, while tiring, was really fun to practice.
