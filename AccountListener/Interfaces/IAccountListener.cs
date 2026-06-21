namespace AccountListener.Interfaces;
//Listener
public interface IAccountListener {
    void onUnderBalance(double balance);
    void onOverBalance(double balance);
}

