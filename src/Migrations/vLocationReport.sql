SELECT     spreadsheet, location, COUNT(*) AS [Total PC count], AVG(total_time * 24) AS [Avg Total time/PC (hr)], AVG(total_count) AS [Avg Login count/PC total], AVG(total_time * 24)
                       / 16 AS [Avg Total time/PC/week (hr)], AVG(total_count) / 16.0 AS [Avg Total count/PC/week], AVG(total_time * 24) / 80 AS [Avg Total time/PC/day], 
                      dbo.Reduce(SUM(total_time * 24), COUNT(*)) AS reduce
FROM         dbo.key_server_entry
GROUP BY spreadsheet, location