namespace SecondaryCourseWorks.GotoException;

// Используется как goto: прерывает обработку Execute работы, если был ввод break в Input
internal class BreakWorkExecuting : Exception;
internal class ProgrammExit : Exception;