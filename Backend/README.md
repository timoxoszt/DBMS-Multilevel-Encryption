# DBMS-Multilevel-Encryption

### Installation

```bash
docker-compose up --build
```

- Install package

```bash
docker-compose exec app composer install
```
- Migrate

```bash
docker-compose exec app php artisan migrate
```

- Seed database

```bash
docker-compose exec app php artisan db:seed
```