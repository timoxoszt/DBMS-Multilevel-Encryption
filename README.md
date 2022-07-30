# DBMS-Multilevel-Encryption
- Vi Minh Tien - 20520810
- Do Xuan Long - 20520619
- Truong Van Hiep - 20521313

## Installation
### Local
```bash
git clone https://github.com/timoxoszt/DBMS-Multilevel-Encryption.git
cd DBMS-Multilevel-Encryption/Backend
cp .env.example .env
composer install
composer update
php artisan key:generate
```
### Docker
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
