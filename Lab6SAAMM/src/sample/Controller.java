package sample;

import javafx.fxml.FXML;


import javafx.scene.control.TextField;

public class Controller {

    @FXML
    TextField l_input,m_input, NumberTextField, nk_out, aveTime,  ATF;

    @FXML
    public void runButtonClick()
    {
        double l = Double.parseDouble(l_input.getText());
        double m = Double.parseDouble(m_input.getText());
        int time = Integer.parseInt(NumberTextField.getText());
        Queue queue = new Queue(l, m, time);

        queue.run(0);

        nk_out.setText(Double.toString(queue.nk_counter / (double) time));
        ATF.setText(Double.toString(queue.outCount /(double) (time)));
        aveTime.setText(Double.toString(queue.counter1 / queue.outCount));
    }
}
