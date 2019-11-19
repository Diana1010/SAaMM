package sample;



import java.util.Random;


public class Queue {
    public  Random random = new Random();
    private final double l, m, time;
    private int state;

    public double e = 2.71828182846;

    public long outCount;
    public double counter1;
    public double nk_counter;

    public double current_time = 0;
    private boolean [] sourceFlags = {false, false, false, false, false, false};
    private double [] sourceTime = {0, 0, 0, 0, 0, 0};
    private int [] channelFlags = {-1, -1};
    private double [] channelTime = {0, 0};

    public Queue(double l, double m, int time)
    {
        this.l = l;
        this.m = m;
        this.time = time;

        outCount = 0;
        counter1 = 0;
        nk_counter = 0;

        state = 0;
    }

    public void run(double current_time) {
        this.current_time = current_time;
        generateNextRequests();
        if(current_time >= time) return;
        updateChannels();
    }

    private void generateNextRequests() {
        for (int i = 0; i < 6; i++) {
            if(!sourceFlags[i]) nextRequest(i);
        }
    }

    private void nextRequest(int i) {
        sourceFlags[i] = true;
        double tmpTime = 0;
        for (int j = 0; j < 2; j++) {
            if(i == channelFlags[j]) tmpTime = channelTime[j];
        }
        sourceTime[i] = tmpTime + -Math.log(random.nextDouble())/l; //время через которое возникнет новая заявка
    }
    
    private void updateChannels() {
        double minTime = time;
        double tmpTime = 0;
        for (int i = 0; i < 2; i++) {
            tmpTime = handleRequest(i);
            if(tmpTime < minTime) minTime = tmpTime;
        }
        run(minTime);
    }

    private double handleRequest(int i) {//время когда освоюодится канал
        int index = findIndexOfMin();
        if(current_time >= channelTime[i]) {
            sourceFlags[index] = false;
            outCount++;//j.hfn
            channelFlags[i] = index;
            double tmp = -Math.log(random.nextDouble()) / l;
            counter1 += tmp;
            if (sourceTime[index] > current_time)
                channelTime[i] = sourceTime[index] + tmp;
            else channelTime[i] = current_time + tmp;
            nk_counter += channelTime[i] - sourceTime[index];
        }
        return channelTime[i];
    }

    
    private int findIndexOfMin() {
        int tmpIndex = 0;
        for (int i = 0; i < 6; i++) {
            if((sourceTime[tmpIndex] > sourceTime[i]) && sourceFlags[i]) tmpIndex = i;
        }
        return  tmpIndex;
    }
}
