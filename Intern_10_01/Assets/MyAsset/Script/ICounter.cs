/*--------------------------------------------------------
 * 
 *      [ICounter.cs]
 *      数を増加、減少させる関数をもつインターフェイス
 * 
 --------------------------------------------------------*/
public interface ICounter
{
    void Add(int count = 1); // 増加
    void Sub(int count = 1); // 減少
}
