# windows-forms-bank-application
A bank aplication using Windows Forms

BD script:
Proiect PAW BD :
CREATE TABLE CLIENTS (
    id_client NUMBER CONSTRAINT pk_id_client PRIMARY KEY,
    first_name VARCHAR2(50) NOT NULL,
    last_name VARCHAR2(50) NOT NULL,
    email VARCHAR2(20),
    phone_number VARCHAR2(15)
);


CREATE TABLE CREDIT_ACCOUNTS (
    id_account NUMBER CONSTRAINT pk_id_account PRIMARY KEY,
    id_client NUMBER,
    sold NUMBER,
    loan_amount NUMBER,
    open_date DATE,
    close_date DATE,
    interest_rate_per_month NUMBER,
    CONSTRAINT fk_client_id FOREIGN KEY (id_client) REFERENCES CLIENTS(id_client)
);


-- Client 1
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (1, 'John', 'Doe', 'johndoe@email.com', '123-456-7890');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (1, 1, 5000, 10000, TO_DATE('15-01-2023', 'DD-MM-YYYY'), TO_DATE('15-06-2024', 'DD-MM-YYYY'), 0.05);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (2, 1, 2000, 5000, TO_DATE('10-05-2022', 'DD-MM-YYYY'), TO_DATE('10-10-2023', 'DD-MM-YYYY'), 0.03);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (3, 1, 10000, 15000, TO_DATE('20-02-2024', 'DD-MM-YYYY'), TO_DATE('20-05-2025', 'DD-MM-YYYY'), 0.06);

-- Client 2
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (2, 'Jane', 'Smith', 'janesmith@email.com', '987-654-3210');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (4, 2, 7000, 15000, TO_DATE('12-08-2023', 'DD-MM-YYYY'), TO_DATE('12-08-2024', 'DD-MM-YYYY'), 0.07);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (5, 2, 3000, 8000, TO_DATE('05-06-2022', 'DD-MM-YYYY'), TO_DATE('05-12-2023', 'DD-MM-YYYY'), 0.04);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (6, 2, 10000, 20000, TO_DATE('10-03-2024', 'DD-MM-YYYY'), TO_DATE('10-03-2025', 'DD-MM-YYYY'), 0.08);

-- Client 3
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (3, 'Michael', 'Williams', 'michaelw@email.com', '111-222-3333');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (7, 3, 6000, 12000, TO_DATE('10-09-2023', 'DD-MM-YYYY'), TO_DATE('10-09-2024', 'DD-MM-YYYY'), 0.06);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (8, 3, 4000, 10000, TO_DATE('15-04-2022', 'DD-MM-YYYY'), TO_DATE('15-11-2022', 'DD-MM-YYYY'), 0.04);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (9, 3, 8000, 15000, TO_DATE('20-01-2024', 'DD-MM-YYYY'), TO_DATE('20-05-2025', 'DD-MM-YYYY'), 0.07);

-- Client 4
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (4, 'Emily', 'Jones', 'emilyj@email.com', '444-555-6666');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (10, 4, 9000, 18000, TO_DATE('25-11-2023', 'DD-MM-YYYY'), TO_DATE('25-11-2024', 'DD-MM-YYYY'), 0.09);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (11, 4, 2000, 6000, TO_DATE('07-07-2022', 'DD-MM-YYYY'), TO_DATE('07-12-2022', 'DD-MM-YYYY'), 0.05);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (12, 4, 5000, 10000, TO_DATE('15-04-2024', 'DD-MM-YYYY'), TO_DATE('15-02-2025', 'DD-MM-YYYY'), 0.06);

-- Client 5
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (5, 'Sophia', 'Brown', 'sophiab@email.com', '555-666-7777');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (13, 5, 7000, 15000, TO_DATE('15-06-2023', 'DD-MM-YYYY'), TO_DATE('15-06-2024', 'DD-MM-YYYY'), 0.07);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (14, 5, 3000, 8000, TO_DATE('20-10-2022', 'DD-MM-YYYY'), TO_DATE('20-12-2022', 'DD-MM-YYYY'), 0.04);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (15, 5, 9000, 20000, TO_DATE('05-08-2024', 'DD-MM-YYYY'), TO_DATE('05-04-2025', 'DD-MM-YYYY'), 0.08);

-- Client 6
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (6, 'Daniel', 'Garcia', 'danielg@email.com', '888-999-0000');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (16, 6, 4000, 10000, TO_DATE('10-07-2023', 'DD-MM-YYYY'), TO_DATE('10-07-2024', 'DD-MM-YYYY'), 0.06);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (17, 6, 6000, 12000, TO_DATE('15-09-2022', 'DD-MM-YYYY'), TO_DATE('15-12-2022', 'DD-MM-YYYY'), 0.05);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (18, 6, 8000, 15000, TO_DATE('20-02-2024', 'DD-MM-YYYY'), TO_DATE('20-04-2026', 'DD-MM-YYYY'), 0.07);

-- Client 7
INSERT INTO CLIENTS (id_client, first_name, last_name, email, phone_number)
VALUES (7, 'Olivia', 'Martinez', 'oliviam@email.com', '111-222-3333');

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (19, 7, 6000, 12000, TO_DATE('05-09-2023', 'DD-MM-YYYY'), TO_DATE('05-09-2024', 'DD-MM-YYYY'), 0.06);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (20, 7, 3000, 8000, TO_DATE('10-11-2022', 'DD-MM-YYYY'), TO_DATE('10-11-2023', 'DD-MM-YYYY'), 0.04);

INSERT INTO CREDIT_ACCOUNTS (id_account, id_client, sold, loan_amount, open_date, close_date, interest_rate_per_month)
VALUES (21, 7, 9000, 20000, TO_DATE('15-03-2022', 'DD-MM-YYYY'), TO_DATE('15-01-2023', 'DD-MM-YYYY'), 0.08);

SELECT * FROM CLIENTS;
SELECT * FROM CREDIT_ACCOUNTS;
