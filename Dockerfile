FROM db
ENV POSTGRES_PASSWORD postgres
ENV POSTGRES_USER postgres
ENV POSTGRES_DB meal_service
COPY meal_service.sql /docker-entrypoint-initdb.d/