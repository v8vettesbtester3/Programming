package ex03;

/*
 Java 03, Exercise 04

Write a Java program which calculates where an arrow will land when shot into the air.  Inputs need to be:
initial angle of trajectory (0 degrees is horizontal, 90 degrees is straight up)
target distance, in units of m.

Loop over values of the initial speed (units of m/s).
In each iteration, calculate how far away from the starting point it lands.
From your series of outputs from each iteration, find out what the

 */

import java.util.Scanner;

public class P04_Arrow {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		// theta is angle of initial trajectory (degrees)
		System.out.print("Enter initial trajectory between 0 and 90 degrees: ");
		double theta = sc.nextDouble();

		// distance to the target (m)
		System.out.print("Enter a distance for the target (m): ");
		double d = sc.nextDouble();

		// initial value of v0 (speed) (m / s)
		double v0 = 1;

		// gravitational acceleration (m / s^2)
		double g = 9.8;

		// time increment per iteration
		double dt = 0.01;
		
		double x = 0;

		// loop over value of speed
		while (true) {
		    // simulate motion y (height) as a function of time t
		    // equations of motion:
		    // x = v0 * cos(theta) * t
		    // y = v0 * sin(theta) * t - (1/2) * g * t^2

		    // loop over values of time (t)
		    double t = 0;
		    while (true) {
		        t = t + dt;  // time step

		        // calculate y for this value of t
		        double y = v0 * Math.sin(Math.toRadians(theta)) * t - 0.5 * g * t * t;

		        // did it hit the ground?
		        if (y <= 0) {
		            // yes it has hit
		            // calculate x for this value of t
		            x = v0 * Math.cos(Math.toRadians(theta)) * t;
		            break;  // stop looping over time
		        }
		    }

		    // check distance
		    // did it overshoot, more than 0.1 m?
		    if (x > d + 0.1) {
		        // too far.  So decrease v0.
		        v0 = v0 * 0.9999;
		    }
		    // did it undershoot, more than 0.1 m?
		    else if (x < d - 0.1) {
		        // not far enough.  So increase v0.
		        v0 = v0 * 1.0001;
		    }
		    // otherwise it must have hit
		    else {
		        // on target. So leave loop over v0.  v0 is our solution.
		        break;
		    }
		}

		// show result
		System.out.print("Final distance (m): ");
		System.out.print(String.format("%.1f", x));
		System.out.print("  Initial speed (m/s): ");
		System.out.println(String.format("%.1f", v0));

	}

}
