# Write your MySQL query statement below
SELECT
    m.employee_id,
    m.name,
    count(*) AS reports_count,
    round(avg(e.age)) AS average_age
FROM
    Employees e
    JOIN Employees m ON e.reports_to = m.employee_id
GROUP BY
    m.employee_id,
    m.name
ORDER BY
    m.employee_id