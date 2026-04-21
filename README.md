# Installing
```bash
corepack enable
pnpm install
```

```bash
brew install docker-compose
```

## Backend
C#, I use Rider to run this, but you can use:
```bash
cd backend
dotnet run --project API/API.csproj
```

if you want to connect to the database
```bash
docker compose docker compose -f docker-compose.db.yml up
```

## Frontend
Angular (analog), and to run locally:
```bash
cd frontend
pnpm vite run
```

## Full app

To run everything (frontend, backend and database) do the following
```bash
docker compose up --build
```