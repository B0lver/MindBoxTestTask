SELECT Product.Name, Category.Name FROM Product
LEFT JOIN Category ON Category.Id = Product.CategoryId
-- имена таблиц и имена полей были произвольно, т.к. в задании не было указаний для имён таблиц и полей.