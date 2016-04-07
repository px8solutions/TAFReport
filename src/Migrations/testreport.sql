-----------------------------------
select spreadsheet,location,
count(name) pcs,
sum(total_time) total_days,
sum(total_time*24) total_hours,
sum(total_time)/count(name) total_days_per_pc,
sum(total_time*24)/count(name) total_hours_per_pc
from key_server_entry
where location='VA4216'
group by spreadsheet,location
------------------------------------------


for VA4216 Fall-13 you had:
pcs: 16
total days: 73
total hours: 1753
days/pc: 4.5
hours/pc: 109
