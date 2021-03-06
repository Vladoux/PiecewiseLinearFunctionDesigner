namespace PiecewiseLinearFunctionDesigner.Localization
{
    public class RussianTextLocalization : ITextLocalization
    {
        public string AppName => "Дизайнер кривых линий";
        public string Functions => "Список функций проекта";
        public string Function => "Функция";
        public string FunctionName => "Имя функции";
        public string FunctionParameters => "Параметры функции";
        public string AddFunction => "Добавить функцию";
        public string FunctionWithNameAlreadyAdded => "Функция с именем '{0}' уже существует";
        public string InvalidFileType => "Неверный формат файла";
        public string UnsavedChanges => "Есть несохраненные изменения.";
        public string DoYouWannaSaveChangesBeforeExit => "Не хотите сохранить изменеия перед выходом?";
        public string ProjectSuccessfullySaved => "Проект успешно сохранен";
        public string Temperature => "Температура";
        public string AbsoluteMark => "Абсолютная отметка";
        public string Graph => "График";
        public string ErrorMessage_ExpectedCsvFormat => "Неверный формат данных. Должен быть CSV.";
        public string ReverseFunction => "Обратная функция";
        public string Reverse => "Обратная";
    }
}